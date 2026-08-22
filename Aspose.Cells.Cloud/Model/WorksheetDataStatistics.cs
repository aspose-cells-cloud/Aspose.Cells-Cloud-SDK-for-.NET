using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents worksheet data statistics.</summary>
public class WorksheetDataStatistics
{
    /// <summary>Represents worksheet name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Represents chart number.</summary>
    [JsonPropertyName("ChartsCount")]
    public int? ChartsCount { get; set; }

    /// <summary>Represents list object number.</summary>
    [JsonPropertyName("TablesCount")]
    public int? TablesCount { get; set; }

    /// <summary>Represents pivot table number.</summary>
    [JsonPropertyName("PivotTablesCount")]
    public int? PivotTablesCount { get; set; }

    /// <summary>Represents shape number.</summary>
    [JsonPropertyName("ShapesCount")]
    public int? ShapesCount { get; set; }

    /// <summary>Represents shape number.</summary>
    [JsonPropertyName("HyperlinksCount")]
    public int? HyperlinksCount { get; set; }

    /// <summary>Represents hyperlink number.</summary>
    [JsonPropertyName("QueryTablesCount")]
    public int? QueryTablesCount { get; set; }

    /// <summary>Represents query table number.</summary>
    [JsonPropertyName("CellsCount")]
    public int? CellsCount { get; set; }

    /// <summary>Represents cell number.</summary>
    [JsonPropertyName("CellsCountInTable")]
    public int? CellsCountInTable { get; set; }

    /// <summary>Represents formula number.</summary>
    [JsonPropertyName("CellsCountIsFormula")]
    public int? CellsCountIsFormula { get; set; }

}
