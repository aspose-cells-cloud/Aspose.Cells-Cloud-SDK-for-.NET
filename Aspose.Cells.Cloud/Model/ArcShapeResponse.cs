using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ArcShape Response.</summary>
public class ArcShapeResponse : CellsCloudResponse
{
    /// <summary>A public property Shape of type ArcShape that can be accessed and modified.</summary>
    [JsonPropertyName("Shape")]
    public ArcShape? Shape { get; set; }

}
