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

    /// <summary>Gets or sets the HTTP request timeout. Defaults to 120 seconds.</summary>
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(120);

    /// <summary>Gets or sets the number of retries for transient failures. Defaults to 0.</summary>
    public int Retries { get; set; } = 0;

    /// <summary>Gets the default headers applied to every request.</summary>
    public Dictionary<string, string> HeaderParameters { get; } = new Dictionary<string, string>();

    /// <summary>Adds or replaces a default header applied to every request.</summary>
    public void AddDefaultHeader(string key, string value) => HeaderParameters[key] = value;
}
