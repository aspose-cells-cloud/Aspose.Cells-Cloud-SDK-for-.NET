using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents operate object position.</summary>
public class OperateObjectPosition
{
    /// <summary>Represents data source of operate object.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents data source of operate object.</summary>
    [JsonPropertyName("Workbook")]
    public FileSource? Workbook { get; set; }

    /// <summary>Represents worksheet name of operate object.</summary>
    [JsonPropertyName("SheetName")]
    public string? SheetName { get; set; }

    /// <summary>Represents chart index of operate object.</summary>
    [JsonPropertyName("ChartIndex")]
    public int? ChartIndex { get; set; }

    /// <summary>Represents shape index of operate object.</summary>
    [JsonPropertyName("ShapeIndex")]
    public int? ShapeIndex { get; set; }

    /// <summary>Represents cell name of operate object.</summary>
    [JsonPropertyName("CellName")]
    public string? CellName { get; set; }

    /// <summary>Represents list object index of operate object.</summary>
    [JsonPropertyName("ListObjectIndex")]
    public int? ListObjectIndex { get; set; }

}
