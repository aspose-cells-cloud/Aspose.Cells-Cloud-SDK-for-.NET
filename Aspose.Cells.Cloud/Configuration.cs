using System;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud;

/// <summary>Runtime configuration for the Aspose.Cells Cloud SDK.</summary>
public class Configuration
{
    /// <summary>Gets or sets the OAuth2 client id used for authentication.</summary>
    public string? ClientId { get; set; }

    /// <summary>Gets or sets the OAuth2 client secret used for authentication.</summary>
    public string? ClientSecret { get; set; }

    /// <summary>Gets or sets the API base URL. Defaults to <c>https://api.aspose.cloud</c>.</summary>
    public string BaseUrl { get; set; } = "https://api.aspose.cloud";

    /// <summary>
    /// Gets or sets the per-call HTTP request timeout. Defaults to 120 seconds. Read at call time, so it
    /// can be changed after construction; it applies to each request attempt (including the OAuth token
    /// request) as a linked <see cref="System.Threading.CancellationToken"/>. Set to <see cref="TimeSpan.Zero"/>
    /// for no timeout.
    /// </summary>
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(120);

    /// <summary>
    /// Gets or sets the number of retries for transient failures. Defaults to 0 (no retries).
    /// Each retry waits with exponential backoff (500ms, 1s, 2s, ... capped at 8s). Only transport-level
    /// failures — <see cref="System.Net.Http.HttpRequestException"/> and the per-call timeout — are
    /// retried; deterministic HTTP errors (4xx/5xx, surfaced as <see cref="SDKException"/>) and a
    /// caller-supplied cancellation are never retried. Note: a retry re-sends the request body, so
    /// <see cref="FileParameter.FromStream"/> requires a seekable stream when retries are enabled;
    /// <see cref="FileParameter.FromPath"/> and <see cref="FileParameter.FromBytes"/> are always
    /// retry-safe.
    /// </summary>
    public int Retries { get; set; } = 0;

    /// <summary>Gets the default headers applied to every request.</summary>
    public Dictionary<string, string> HeaderParameters { get; } = new Dictionary<string, string>();

    /// <summary>Adds or replaces a default header applied to every request.</summary>
    public void AddDefaultHeader(string key, string value) => HeaderParameters[key] = value;
}
