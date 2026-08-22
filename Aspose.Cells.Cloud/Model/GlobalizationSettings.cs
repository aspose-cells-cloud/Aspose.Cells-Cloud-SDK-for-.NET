using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the globalization settings.</summary>
public class GlobalizationSettings
{
    /// <summary>Gets or sets the globalization settings for Chart.</summary>
    [JsonPropertyName("ChartSettings")]
    public ChartGlobalizationSettings? ChartSettings { get; set; }

    /// <summary>Gets or sets the globalization settings for pivot table.</summary>
    [JsonPropertyName("PivotSettings")]
    public PivotGlobalizationSettings? PivotSettings { get; set; }

    /// <summary>Gets the separator for list, parameters of function, ...etc.</summary>
    [JsonPropertyName("ListSeparator")]
    public string? ListSeparator { get; set; }

    /// <summary>Gets the separator for rows in array data in formula.</summary>
    [JsonPropertyName("RowSeparatorOfFormulaArray")]
    public string? RowSeparatorOfFormulaArray { get; set; }

    /// <summary>Gets the separator for the items in array's row data in formula.</summary>
    [JsonPropertyName("ColumnSeparatorOfFormulaArray")]
    public string? ColumnSeparatorOfFormulaArray { get; set; }

}
