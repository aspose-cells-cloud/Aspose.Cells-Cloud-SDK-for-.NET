using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Link model.</summary>
public class Link
{
    /// <summary>Has a property named Href with the attribute ElementName set to "href".</summary>
    [JsonPropertyName("Href")]
    public string? Href { get; set; }

    /// <summary>Gets or sets the Rel.</summary>
    [JsonPropertyName("Rel")]
    public string? Rel { get; set; }

    /// <summary>Gets or sets the Title.</summary>
    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    /// <summary>Gets or sets the Type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

}
