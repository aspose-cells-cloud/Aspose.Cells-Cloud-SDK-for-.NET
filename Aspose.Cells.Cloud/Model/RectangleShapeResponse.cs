using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the RectangleShape Response.</summary>
public class RectangleShapeResponse : CellsCloudResponse
{
    /// <summary>A public property named "Shape" that is of type RectangleShape and can be both accessed and modified.</summary>
    [JsonPropertyName("Shape")]
    public RectangleShape? Shape { get; set; }

}
