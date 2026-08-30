using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PageSection model.</summary>
public class PageSection
{
    /// <summary>0,1,2  left , middle ,right</summary>
    [JsonPropertyName("Section")]
    public int? Section { get; set; }

    /// <summary>page context script</summary>
    [JsonPropertyName("Context")]
    public string? Context { get; set; }

    /// <summary>A property named "Picture" with both getter and setter methods of type string is defined.</summary>
    [JsonPropertyName("Picture")]
    public string? Picture { get; set; }

    /// <summary>fisrt page context script</summary>
    [JsonPropertyName("FisrtPageContext")]
    public string? FisrtPageContext { get; set; }

    /// <summary>Even page context script</summary>
    [JsonPropertyName("EvenPageContext")]
    public string? EvenPageContext { get; set; }

}
