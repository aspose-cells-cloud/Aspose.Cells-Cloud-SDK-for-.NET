using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a single row in a worksheet.</summary>
public class Row : LinkElement
{
    /// <summary>Gets the group level of the row.</summary>
    [JsonPropertyName("GroupLevel")]
    public int? GroupLevel { get; set; }

    /// <summary>Gets and sets the row height in unit of Points.</summary>
    [JsonPropertyName("Height")]
    public double? Height { get; set; }

    /// <summary>Gets the index of this row.</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>Indicates whether the row contains any data</summary>
    [JsonPropertyName("IsBlank")]
    public bool? IsBlank { get; set; }

    /// <summary>Indicates that row height and default font height matches.</summary>
    [JsonPropertyName("IsHeightMatched")]
    public bool? IsHeightMatched { get; set; }

    /// <summary>Indicates whether the row is hidden.</summary>
    [JsonPropertyName("IsHidden")]
    public bool? IsHidden { get; set; }

    /// <summary>Represents the style of this row.</summary>
    [JsonPropertyName("Style")]
    public LinkElement? Style { get; set; }

}
