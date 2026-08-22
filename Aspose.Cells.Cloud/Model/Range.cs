using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Range model.</summary>
public class Range
{
    /// <summary>Gets or sets the ColumnCount.</summary>
    [JsonPropertyName("ColumnCount")]
    public int? ColumnCount { get; set; }

    /// <summary>Gets or sets the ColumnWidth.</summary>
    [JsonPropertyName("ColumnWidth")]
    public double? ColumnWidth { get; set; }

    /// <summary>Gets or sets the FirstColumn.</summary>
    [JsonPropertyName("FirstColumn")]
    public int? FirstColumn { get; set; }

    /// <summary>Gets or sets the FirstRow.</summary>
    [JsonPropertyName("FirstRow")]
    public int? FirstRow { get; set; }

    /// <summary>Gets or sets the Name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the RefersTo.</summary>
    [JsonPropertyName("RefersTo")]
    public string? RefersTo { get; set; }

    /// <summary>Gets or sets the RowCount.</summary>
    [JsonPropertyName("RowCount")]
    public int? RowCount { get; set; }

    /// <summary>Gets or sets the RowHeight.</summary>
    [JsonPropertyName("RowHeight")]
    public double? RowHeight { get; set; }

    /// <summary>Gets or sets the Worksheet.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

}
