using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents  the custom  icon of conditional formatting rule.</summary>
public class ConditionalFormattingIcon
{
    /// <summary>Gets the icon set data.</summary>
    [JsonPropertyName("ImageData")]
    public string? ImageData { get; set; }

    /// <summary>Gets and sets the icon's index in the icon set.</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>Gets and sets the icon set type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

}
