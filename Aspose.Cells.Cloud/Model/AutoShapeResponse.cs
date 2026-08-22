using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the AutoShape Response.</summary>
public class AutoShapeResponse : CellsCloudResponse
{
    /// <summary>A public property named "AutoShape" of type "AutoShape" with both getter and setter methods.</summary>
    [JsonPropertyName("AutoShape")]
    public AutoShape? AutoShape { get; set; }

}
