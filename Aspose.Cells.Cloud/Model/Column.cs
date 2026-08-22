using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a single column in a worksheet.</summary>
public class Column : LinkElement
{
    /// <summary>Gets the group level of the column.</summary>
    [JsonPropertyName("GroupLevel")]
    public int? GroupLevel { get; set; }

    /// <summary>Gets the index of this column.</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>Indicates whether the column is hidden.</summary>
    [JsonPropertyName("IsHidden")]
    public bool? IsHidden { get; set; }

    /// <summary>Gets and sets the column width in unit of characters.</summary>
    [JsonPropertyName("Width")]
    public double? Width { get; set; }

    /// <summary>Gets the style of this column.</summary>
    [JsonPropertyName("Style")]
    public LinkElement? Style { get; set; }

}
