using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Aspose.Cells.Cloud;

/// <summary>
/// The Aspose.Cells Cloud API client. Authenticates via OAuth2 client-credentials and executes
/// <see cref="IRequestOption"/> requests against the REST API.
/// </summary>
public class AsposeCellsCloudClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly SemaphoreSlim _tokenLock = new SemaphoreSlim(1, 1);
    private string? _accessToken;
    private DateTime _tokenExpiry = DateTime.MinValue;

    /// <summary>Gets the runtime configuration for this client.</summary>
    public Configuration Configuration { get; }

    /// <summary>Gets the JSON serializer options used for request bodies.</summary>
    public JsonSerializerOptions JsonOptions { get; }

    /// <summary>
    /// Creates a client with the default transport, authenticating with the supplied client-credentials.
    /// </summary>
    public AsposeCellsCloudClient(string clientId, string clientSecret, string? baseUrl = null)
        : this(handler: null, clientId, clientSecret, baseUrl)
    {
    }

    /// <summary>
    /// Creates a client over an externally supplied <see cref="HttpMessageHandler"/> (used for test mocks
    /// or a custom transport such as tracing or mTLS). The caller retains ownership of the handler.
    /// </summary>
    public AsposeCellsCloudClient(HttpMessageHandler? handler, string clientId, string clientSecret, string? baseUrl = null)
    {
        if (string.IsNullOrEmpty(clientId))
        {
            throw new ArgumentNullException(nameof(clientId));
        }

        if (string.IsNullOrEmpty(clientSecret))
        {
            throw new ArgumentNullException(nameof(clientSecret));
        }

        Configuration = new Configuration
        {
            ClientId = clientId,
            ClientSecret = clientSecret,
            BaseUrl = string.IsNullOrEmpty(baseUrl) ? "https://api.aspose.cloud" : baseUrl,
        };

        JsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        };

        // Configuration.Timeout is applied per request (a linked CancellationTokenSource) so it can be
        // changed after construction and so the retry loop stays within the caller's budget. Leave the
        // HttpClient-level timeout infinite — a fixed HttpClient.Timeout could not be adjusted at runtime.
        _httpClient = handler is null
            ? new HttpClient { BaseAddress = new Uri(Configuration.BaseUrl), Timeout = Timeout.InfiniteTimeSpan }
            : new HttpClient(handler, disposeHandler: false) { BaseAddress = new Uri(Configuration.BaseUrl), Timeout = Timeout.InfiniteTimeSpan };
    }

    /// <summary>
    /// Releases the underlying <see cref="HttpClient"/> and the token-cache lock. Dispose the client before
    /// the process exits so the connection pool is not leaked. In-flight calls are not interrupted.
    /// </summary>
    public void Dispose()
    {
        _httpClient.Dispose();
        _tokenLock.Dispose();
        GC.SuppressFinalize(this);
    }

    /// <summary>Requests an OAuth2 access token using the client-credentials grant.</summary>
    public async Task<string> RequestOauthTokenAsync(CancellationToken cancellationToken = default)
    {
        var form = new Dictionary<string, string>
        {
            ["grant_type"] = "client_credentials",
            ["client_id"] = Configuration.ClientId ?? string.Empty,
            ["client_secret"] = Configuration.ClientSecret ?? string.Empty,
        };

        using var content = new FormUrlEncodedContent(form);
        using var request = new HttpRequestMessage(HttpMethod.Post, new Uri(_httpClient.BaseAddress!, "/connect/token"))
        {
            Content = content,
        };

        HttpResponseMessage response;
        try
        {
            response = await SendWithTimeoutAsync(request, cancellationToken).ConfigureAwait(false);
        }
        catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
        {
            throw new SDKException($"The OAuth token request timed out after {Configuration.Timeout.TotalSeconds:0.#} seconds.");
        }

        using (response)
        {
            var body = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                throw new SDKException((int)response.StatusCode, $"OAuth token request failed: {body}");
            }

            using var doc = JsonDocument.Parse(body);
            var root = doc.RootElement;
            _accessToken = root.TryGetProperty("access_token", out var token) ? token.GetString() : null;
            if (string.IsNullOrEmpty(_accessToken))
            {
                throw new SDKException("OAuth token response did not contain an access_token.");
            }

            var expiresIn = root.TryGetProperty("expires_in", out var expires) ? expires.GetInt32() : 3600;
            _tokenExpiry = DateTime.UtcNow.AddSeconds(expiresIn - 60);
            return _accessToken;
        }
    }

    private bool TokenIsValid() => _accessToken is not null && DateTime.UtcNow < _tokenExpiry;

    // Fetches a token on first use or when the cached one is close to expiring. A SemaphoreSlim prevents
    // concurrent token requests when many callers race past the initial check (double-checked locking).
    private async Task EnsureTokenAsync(CancellationToken cancellationToken)
    {
        if (TokenIsValid())
        {
            return;
        }

        await _tokenLock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (!TokenIsValid())
            {
                await RequestOauthTokenAsync(cancellationToken).ConfigureAwait(false);
            }
        }
        finally
        {
            _tokenLock.Release();
        }
    }

    /// <summary>Executes a single request synchronously.</summary>
    public RichResponse Do(IRequestOption request) => DoAsync(request).GetAwaiter().GetResult();

    /// <summary>
    /// Executes a single request asynchronously. Applies <see cref="Configuration.Timeout"/> as a per-call
    /// deadline and retries transient transport failures up to <see cref="Configuration.Retries"/> times
    /// with exponential backoff. Deterministic HTTP errors (4xx/5xx) and the caller's own cancellation are
    /// never retried.
    /// </summary>
    public async Task<RichResponse> DoAsync(IRequestOption request, CancellationToken cancellationToken = default)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        await EnsureTokenAsync(cancellationToken).ConfigureAwait(false);

        var retries = Math.Max(0, Configuration.Retries);
        var backoff = TimeSpan.FromMilliseconds(500);

        for (var attempt = 0; ; attempt++)
        {
            try
            {
                return await ExecuteAttemptAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested && attempt < retries)
            {
                // Configuration.Timeout elapsed on this attempt (the caller did not cancel); back off and
                // retry within the caller's overall budget, since the caller's token is still active.
                await Task.Delay(backoff, cancellationToken).ConfigureAwait(false);
                backoff = NextBackoff(backoff);
            }
            catch (HttpRequestException) when (attempt < retries)
            {
                // Transient transport error (connection refused/reset, DNS, proxy). Retry with backoff.
                await Task.Delay(backoff, cancellationToken).ConfigureAwait(false);
                backoff = NextBackoff(backoff);
            }
            catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
            {
                throw new SDKException($"The request timed out after {Configuration.Timeout.TotalSeconds:0.#} seconds.");
            }
            catch (HttpRequestException ex)
            {
                throw new SDKException($"The HTTP request failed after {attempt} retr{(attempt == 1 ? "y" : "ies")}: {ex.Message}", ex);
            }
        }
    }

    private static TimeSpan NextBackoff(TimeSpan current) =>
        current < TimeSpan.FromSeconds(8) ? TimeSpan.FromMilliseconds(current.TotalMilliseconds * 2) : TimeSpan.FromSeconds(8);

    private async Task<RichResponse> ExecuteAttemptAsync(IRequestOption request, CancellationToken cancellationToken)
    {
        using var httpRequest = BuildRequest(request);
        using var response = await SendWithTimeoutAsync(httpRequest, cancellationToken).ConfigureAwait(false);
        var body = await response.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);

        var headers = new Dictionary<string, string>();
        foreach (var header in response.Headers)
        {
            headers[header.Key] = string.Join(", ", header.Value);
        }

        foreach (var header in response.Content.Headers)
        {
            headers[header.Key] = string.Join(", ", header.Value);
        }

        var richResponse = new RichResponse((int)response.StatusCode, headers, body);
        if (!response.IsSuccessStatusCode)
        {
            // Deterministic HTTP failures (4xx/5xx) are never retried.
            throw new SDKException(richResponse);
        }

        return richResponse;
    }

    /// <summary>Sends a request applying <see cref="Configuration.Timeout"/> as a per-call deadline.</summary>
    private async Task<HttpResponseMessage> SendWithTimeoutAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        if (Configuration.Timeout > TimeSpan.Zero)
        {
            timeoutCts.CancelAfter(Configuration.Timeout);
        }

        return await _httpClient.SendAsync(request, timeoutCts.Token).ConfigureAwait(false);
    }

    /// <summary>Executes a batch of requests sequentially, returning one response per request.</summary>
    public RichResponse[] DoBatch(params IRequestOption[] requests) => DoBatchAsync(requests).GetAwaiter().GetResult();

    /// <summary>Executes a batch of requests sequentially, returning one response per request.</summary>
    public async Task<RichResponse[]> DoBatchAsync(IRequestOption[] requests, CancellationToken cancellationToken = default)
    {
        if (requests is null)
        {
            throw new ArgumentNullException(nameof(requests));
        }

        var results = new RichResponse[requests.Length];
        for (var i = 0; i < requests.Length; i++)
        {
            results[i] = await DoAsync(requests[i], cancellationToken).ConfigureAwait(false);
        }

        return results;
    }

    private HttpRequestMessage BuildRequest(IRequestOption request)
    {
        var uri = Configuration.BaseUrl.TrimEnd('/') + request.GetPath();

        var query = request.GetQueryParameters();
        if (query is not null && query.Count > 0)
        {
            var builder = new StringBuilder();
            foreach (var pair in query)
            {
                builder.Append(builder.Length == 0 ? '?' : '&')
                       .Append(Uri.EscapeDataString(pair.Key))
                       .Append('=')
                       .Append(Uri.EscapeDataString(pair.Value ?? string.Empty));
            }

            uri += builder.ToString();
        }

        var message = new HttpRequestMessage(new HttpMethod(request.GetMethod()), uri);

        foreach (var pair in Configuration.HeaderParameters)
        {
            message.Headers.TryAddWithoutValidation(pair.Key, pair.Value);
        }

        foreach (var pair in request.GetHeaderParameters() ?? new Dictionary<string, string>())
        {
            if (!string.Equals(pair.Key, "Content-Type", StringComparison.OrdinalIgnoreCase))
            {
                message.Headers.TryAddWithoutValidation(pair.Key, pair.Value);
            }
        }

        if (!string.IsNullOrEmpty(_accessToken))
        {
            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        }

        var form = request.GetMultipartForm();
        if (form is not null && form.Count > 0)
        {
            var multipart = new MultipartFormDataContent();
            foreach (var pair in form)
            {
                if (pair.Key.StartsWith("@", StringComparison.Ordinal))
                {
                    var partName = pair.Key.Substring(1);
                    if (pair.Value is FileParameter file)
                    {
                        multipart.Add(FileParameterToHttpContent(file), partName, file.FileName);
                    }
                    else
                    {
                        var filePath = pair.Value?.ToString() ?? string.Empty;
                        var fileName = Path.GetFileName(filePath);
                        multipart.Add(new ByteArrayContent(File.ReadAllBytes(filePath)), partName, fileName);
                    }
                }
                else
                {
                    multipart.Add(new StringContent(pair.Value?.ToString() ?? string.Empty), pair.Key);
                }
            }

            message.Content = multipart;
        }
        else
        {
            var body = request.GetJsonBody();
            if (body is not null)
            {
                message.Content = new StringContent(JsonSerializer.Serialize(body, JsonOptions), Encoding.UTF8, "application/json");
            }
        }

        return message;
    }

    private static HttpContent FileParameterToHttpContent(FileParameter file)
    {
        // Retries re-send the request; a seekable caller stream must be rewound so the second attempt
        // carries the full body. Non-seekable streams (e.g. a network stream) are single-use — enable
        // Configuration.Retries with FromPath/FromBytes for retry-safe uploads.
        if (file.Stream is not null && file.Stream.CanSeek)
        {
            file.Stream.Position = 0;
        }

        HttpContent content;
        if (!string.IsNullOrEmpty(file.LocalPath))
        {
            // Open lazily so large files stream from disk instead of being buffered entirely in memory.
            content = new StreamContent(File.OpenRead(file.LocalPath));
        }
        else if (file.Stream is not null)
        {
            content = new StreamContent(file.Stream);
        }
        else
        {
            content = new ByteArrayContent(file.Bytes ?? Array.Empty<byte>());
        }

        if (!string.IsNullOrEmpty(file.ContentType))
        {
            content.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
        }

        return content;
    }
}
