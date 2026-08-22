using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PivotField Response.</summary>
public class PivotFieldResponse : CellsCloudResponse
{
    /// <summary>This class has a property named "PivotField" of type PivotField which can be accessed and modified.</summary>
    [JsonPropertyName("PivotField")]
    public PivotField? PivotField { get; set; }

}
