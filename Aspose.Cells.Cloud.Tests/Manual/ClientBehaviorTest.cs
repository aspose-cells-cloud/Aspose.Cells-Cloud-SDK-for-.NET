using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Request;
using Xunit;

/// <summary>
/// Hand-written offline unit tests for <see cref="AsposeCellsCloudClient"/> behaviour: token caching,
/// the Bearer authorization header, retry/backoff, the per-call timeout, and batch execution. A fake
/// <see cref="HttpMessageHandler"/> is injected so no network access or credentials are required.
/// Lives in Manual/ so the test-code generator (which wipes top-level *.cs) does not overwrite it.
/// </summary>
public class ClientBehaviorTest
{
    private const string TokenJson = """{"access_token":"tok","expires_in":3600}""";

    [Fact]
    public void SendsBearerTokenAfterTokenRefresh()
    {
        string? lastAuthorization = null;
        var handler = new FakeHandler((request, ct, call) =>
        {
            if (IsTokenRequest(request))
            {
                return Task.FromResult(JsonResponse(HttpStatusCode.OK, TokenJson));
            }

            lastAuthorization = request.Headers.Authorization?.ToString();
            return Task.FromResult(JsonResponse(HttpStatusCode.OK, "{}"));
        });

        using var client = new AsposeCellsCloudClient(handler, "id", "secret");
        client.Do(new DownloadFileRequest("a.xlsx"));

        Assert.Equal("Bearer tok", lastAuthorization);
    }

    [Fact]
    public void ReusesCachedTokenAcrossRequests()
    {
        var tokenCalls = 0;
        var handler = new FakeHandler((request, ct, call) =>
        {
            if (IsTokenRequest(request))
            {
                Interlocked.Increment(ref tokenCalls);
                return Task.FromResult(JsonResponse(HttpStatusCode.OK, TokenJson));
            }

            return Task.FromResult(JsonResponse(HttpStatusCode.OK, "{}"));
        });

        using var client = new AsposeCellsCloudClient(handler, "id", "secret");
        client.Do(new DownloadFileRequest("a.xlsx"));
        client.Do(new DownloadFileRequest("b.xlsx"));

        Assert.Equal(1, tokenCalls);
    }

    [Fact]
    public void RetriesTransientTransportFailuresWithBackoff()
    {
        var handler = new FakeHandler((request, ct, call) =>
        {
            if (IsTokenRequest(request))
            {
                return Task.FromResult(JsonResponse(HttpStatusCode.OK, TokenJson));
            }

            // Token request is call 1; API attempts are calls 2, 3 (fault) and 4 (success).
            return call < 4
                ? Task.FromException<HttpResponseMessage>(new HttpRequestException("transient failure"))
                : Task.FromResult(JsonResponse(HttpStatusCode.OK, "{}"));
        });

        using var client = new AsposeCellsCloudClient(handler, "id", "secret");
        client.Configuration.Retries = 2;

        var response = client.Do(new DownloadFileRequest("x.xlsx"));

        Assert.Equal(200, response.StatusCode);
        Assert.Equal(4, handler.Calls); // 1 token + 2 failed attempts + 1 successful attempt
    }

    [Fact]
    public void DoesNotRetryDeterministicHttpErrors()
    {
        var handler = new FakeHandler((request, ct, call) =>
            IsTokenRequest(request)
                ? Task.FromResult(JsonResponse(HttpStatusCode.OK, TokenJson))
                : Task.FromResult(JsonResponse(HttpStatusCode.BadRequest, """{"error":"bad request"}""")));

        using var client = new AsposeCellsCloudClient(handler, "id", "secret");
        client.Configuration.Retries = 3;

        var ex = Assert.Throws<SDKException>(() => client.Do(new DownloadFileRequest("x.xlsx")));

        Assert.Equal(400, ex.StatusCode);
        Assert.Equal(2, handler.Calls); // 1 token + a single API attempt (no retry on 4xx)
    }

    [Fact]
    public void TimesOutWhenConfigurationTimeoutElapses()
    {
        var handler = new FakeHandler(async (request, ct, call) =>
        {
            if (IsTokenRequest(request))
            {
                return JsonResponse(HttpStatusCode.OK, TokenJson);
            }

            await Task.Delay(500, ct);
            return JsonResponse(HttpStatusCode.OK, "{}");
        });

        using var client = new AsposeCellsCloudClient(handler, "id", "secret");
        client.Configuration.Retries = 0;
        client.Configuration.Timeout = TimeSpan.FromMilliseconds(100);

        var ex = Assert.Throws<SDKException>(() => client.Do(new DownloadFileRequest("x.xlsx")));

        Assert.Contains("timed out", ex.Message);
    }

    [Fact]
    public async Task DoBatchAsyncExecutesEachRequest()
    {
        var handler = new FakeHandler((request, ct, call) =>
            IsTokenRequest(request)
                ? Task.FromResult(JsonResponse(HttpStatusCode.OK, TokenJson))
                : Task.FromResult(JsonResponse(HttpStatusCode.OK, "{}")));

        using var client = new AsposeCellsCloudClient(handler, "id", "secret");
        var results = await client.DoBatchAsync(
            new IRequestOption[] { new DownloadFileRequest("a.xlsx"), new DownloadFileRequest("b.xlsx") });

        Assert.Equal(2, results.Length);
        Assert.All(results, r => Assert.Equal(200, r.StatusCode));
        Assert.Equal(3, handler.Calls); // 1 token + 2 API requests
    }

    private static bool IsTokenRequest(HttpRequestMessage request) =>
        string.Equals(request.RequestUri?.AbsolutePath, "/connect/token", StringComparison.OrdinalIgnoreCase);

    private static HttpResponseMessage JsonResponse(HttpStatusCode status, string json) =>
        new(status) { Content = new StringContent(json, Encoding.UTF8, "application/json") };

    /// <summary>
    /// A test <see cref="HttpMessageHandler"/> that routes every request to a delegate. It records the
    /// number of calls so tests can assert on retry/backoff behaviour.
    /// </summary>
    private sealed class FakeHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, CancellationToken, int, Task<HttpResponseMessage>> _handler;
        private int _calls;

        public FakeHandler(Func<HttpRequestMessage, CancellationToken, int, Task<HttpResponseMessage>> handler) =>
            _handler = handler;

        /// <summary>Total number of requests the handler has received (token + API calls).</summary>
        public int Calls => _calls;

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
            _handler(request, cancellationToken, Interlocked.Increment(ref _calls));
    }
}
