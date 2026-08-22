using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ChartDataTable Response.</summary>
public class ChartDataTableResponse : CellsCloudResponse
{
    /// <summary>This property allows access to a ChartDataTable object for storing and manipulating data related to a chart.</summary>
    [JsonPropertyName("ChartDataTable")]
    public ChartDataTable? ChartDataTable { get; set; }

}
