using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ChartPoint Response.</summary>
public class ChartPointResponse : CellsCloudResponse
{
    /// <summary>A public property "ChartPoint" that can store and retrieve instances of the "ChartPoint" data type.</summary>
    [JsonPropertyName("ChartPoint")]
    public ChartPoint? ChartPoint { get; set; }

}
