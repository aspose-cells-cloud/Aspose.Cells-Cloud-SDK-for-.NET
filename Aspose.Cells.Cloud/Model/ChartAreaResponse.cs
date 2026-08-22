using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ChartArea Response.</summary>
public class ChartAreaResponse : CellsCloudResponse
{
    /// <summary>This class has a property named "ChartArea" of type ChartArea with a getter and setter.</summary>
    [JsonPropertyName("ChartArea")]
    public ChartArea? ChartArea { get; set; }

}
