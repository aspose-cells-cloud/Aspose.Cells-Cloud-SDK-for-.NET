using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents analyzed table description.</summary>
public class AnalyzedTableDescription
{
    /// <summary>Represents table name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Represents worksheet name which is where the table is located.</summary>
    [JsonPropertyName("SheetName")]
    public string? SheetName { get; set; }

    /// <summary>Represents analyzed description about table columns.</summary>
    [JsonPropertyName("Columns")]
    public List<AnalyzedColumnDescription>? Columns { get; set; }

    /// <summary>Represents date columns list.</summary>
    [JsonPropertyName("DateColumns")]
    public List<int>? DateColumns { get; set; }

    /// <summary>Represents number columns list.</summary>
    [JsonPropertyName("NumberColumns")]
    public List<int>? NumberColumns { get; set; }

    /// <summary>Represents string columns list.</summary>
    [JsonPropertyName("TextColumns")]
    public List<int>? TextColumns { get; set; }

    /// <summary>Represents exception columns list.</summary>
    [JsonPropertyName("ExceptionColumns")]
    public List<int>? ExceptionColumns { get; set; }

    /// <summary>Represents there is a table header in the table.</summary>
    [JsonPropertyName("HasTableHeaderRow")]
    public bool? HasTableHeaderRow { get; set; }

    /// <summary>Represents there is a total row in the table.</summary>
    [JsonPropertyName("HasTableTotalRow")]
    public bool? HasTableTotalRow { get; set; }

    /// <summary>Represents the column index as the start data column.</summary>
    [JsonPropertyName("StartDataColumnIndex")]
    public int? StartDataColumnIndex { get; set; }

    /// <summary>Represents the column index as the end data column.</summary>
    [JsonPropertyName("EndDataColumnIndex")]
    public int? EndDataColumnIndex { get; set; }

    /// <summary>Represents the row index as the start data row.</summary>
    [JsonPropertyName("StartDataRowIndex")]
    public int? StartDataRowIndex { get; set; }

    /// <summary>Represents the row index as the end data row.</summary>
    [JsonPropertyName("EndDataRowIndex")]
    public int? EndDataRowIndex { get; set; }

    /// <summary>Represents table thumbnail. Base64String</summary>
    [JsonPropertyName("Thumbnail")]
    public string? Thumbnail { get; set; }

    /// <summary>Represents a collection of charts, which is a collection of charts created based on data analysis of a table.</summary>
    [JsonPropertyName("DiscoverCharts")]
    public List<DiscoverChart>? DiscoverCharts { get; set; }

    /// <summary>Represents a collection of pivot tables, which is a collection of pivot tables created based on data analysis of a table.</summary>
    [JsonPropertyName("DiscoverPivotTables")]
    public List<DiscoverPivotTable>? DiscoverPivotTables { get; set; }

}
