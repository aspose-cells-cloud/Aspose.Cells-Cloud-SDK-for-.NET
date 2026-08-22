using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents cells object operate task parameter.</summary>
public class CellsObjectOperateTaskParameter : TaskParameter
{
    /// <summary>Represents object operate.</summary>
    [JsonPropertyName("OperateObject")]
    public OperateObject? OperateObject { get; set; }

    /// <summary>Represents operate parameter.</summary>
    [JsonPropertyName("OperateParameter")]
    public OperateParameter? OperateParameter { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("DestinationDataSource")]
    public DataSource? DestinationDataSource { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("DestinationWorkbook")]
    public FileSource? DestinationWorkbook { get; set; }

}
