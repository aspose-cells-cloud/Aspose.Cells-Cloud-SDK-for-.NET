using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the MergedCells Response.</summary>
public class MergedCellsResponse : CellsCloudResponse
{
    /// <summary>Property Summary: Contains information about merged cells within a spreadsheet.</summary>
    [JsonPropertyName("MergedCells")]
    public MergedCells? MergedCells { get; set; }

}
