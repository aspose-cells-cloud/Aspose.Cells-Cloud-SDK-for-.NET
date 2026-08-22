using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PivotFilter Response.</summary>
public class PivotFilterResponse : CellsCloudResponse
{
    /// <summary>Property Summary: Contains a pivot filter for data manipulation.</summary>
    [JsonPropertyName("PivotFilter")]
    public PivotFilter? PivotFilter { get; set; }

}
