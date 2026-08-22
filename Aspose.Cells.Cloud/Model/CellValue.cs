using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the cell value and corresponding type.</summary>
public class CellValue
{
    /// <summary>A public integer property called "rowIndex" with both getter and setter.</summary>
    [JsonPropertyName("rowIndex")]
    public int? RowIndex { get; set; }

    /// <summary>Gets or sets the columnIndex.</summary>
    [JsonPropertyName("columnIndex")]
    public int? ColumnIndex { get; set; }

    /// <summary>Gets or sets the type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets the value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Gets or sets the formula.</summary>
    [JsonPropertyName("formula")]
    public string? Formula { get; set; }

    /// <summary>Gets or sets the style.</summary>
    [JsonPropertyName("style")]
    public Style? Style { get; set; }

}
