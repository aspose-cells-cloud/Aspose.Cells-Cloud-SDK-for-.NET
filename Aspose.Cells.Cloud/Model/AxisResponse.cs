using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Axis Response.</summary>
public class AxisResponse : CellsCloudResponse
{
    /// <summary>A property named "Axis" of type "Axis" with both getter and setter methods is present in the class.</summary>
    [JsonPropertyName("Axis")]
    public Axis? Axis { get; set; }

}
