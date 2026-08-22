using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the MarkdownSaveOptions model.</summary>
public class MarkdownSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the Encoding.</summary>
    [JsonPropertyName("Encoding")]
    public string? Encoding { get; set; }

    /// <summary>Gets or sets the FormatStrategy.</summary>
    [JsonPropertyName("FormatStrategy")]
    public string? FormatStrategy { get; set; }

    /// <summary>Gets or sets the LineSeparator.</summary>
    [JsonPropertyName("LineSeparator")]
    public string? LineSeparator { get; set; }

}
