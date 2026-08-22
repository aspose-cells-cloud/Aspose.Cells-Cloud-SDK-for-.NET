using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PivotTable Response.</summary>
public class PivotTableResponse : CellsCloudResponse
{
    /// <summary>PivotTable property of type PivotTable that can be both read and written.</summary>
    [JsonPropertyName("PivotTable")]
    public PivotTable? PivotTable { get; set; }

}
