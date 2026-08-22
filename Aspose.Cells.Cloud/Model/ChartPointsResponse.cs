using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ChartPoints Response.</summary>
public class ChartPointsResponse : CellsCloudResponse
{
    /// <summary>This class has a property named `ChartPoints` of type `ChartPoints` that can be accessed and modified.</summary>
    [JsonPropertyName("ChartPoints")]
    public ChartPoints? ChartPoints { get; set; }

}
