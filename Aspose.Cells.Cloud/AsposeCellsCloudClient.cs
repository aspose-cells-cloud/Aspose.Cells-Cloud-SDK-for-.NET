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
public class AsposeCellsCloudClient
{
    private readonly HttpClient _httpClient;
    private string? _accessToken;
    private DateTime _tokenExpiry = DateTime.MinValue;

    /// <summary>Gets the runtime configuration for this client.</summary>
    public Configuration Configuration { get; }

    /// <summary>Gets the JSON serializer options used for request bodies.</summary>
    public JsonSerializerOptions JsonOptions { get; }

    public AsposeCellsCloudClient(string clientId, string clientSecret, string? baseUrl = null)
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

        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(Configuration.BaseUrl),
            Timeout = Configuration.Timeout,
        };
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
        using var response = await _httpClient.PostAsync("/connect/token", content, cancellationToken).ConfigureAwait(false);
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

    private async Task EnsureTokenAsync(CancellationToken cancellationToken)
    {
        if (_accessToken is null || DateTime.UtcNow >= _tokenExpiry)
        {
            await RequestOauthTokenAsync(cancellationToken).ConfigureAwait(false);
        }
    }

    /// <summary>Executes a single request synchronously.</summary>
    public RichResponse Do(IRequestOption request) => DoAsync(request).GetAwaiter().GetResult();

    /// <summary>Executes a single request asynchronously.</summary>
    public async Task<RichResponse> DoAsync(IRequestOption request, CancellationToken cancellationToken = default)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        await EnsureTokenAsync(cancellationToken).ConfigureAwait(false);

        using var httpRequest = BuildRequest(request);
        using var response = await _httpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
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
            throw new SDKException(richResponse);
        }

        return richResponse;
    }

    /// <summary>Executes a batch of requests sequentially, returning one response per request.</summary>
    public RichResponse[] DoBatch(params IRequestOption[] requests)
    {
        if (requests is null)
        {
            throw new ArgumentNullException(nameof(requests));
        }

        var results = new RichResponse[requests.Length];
        for (var i = 0; i < requests.Length; i++)
        {
            results[i] = Do(requests[i]);
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
