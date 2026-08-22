using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Shape Response.</summary>
public class ShapeResponse : CellsCloudResponse
{
    /// <summary>A public property Shape of type ArcShape that can be accessed and modified.</summary>
    [JsonPropertyName("Shape")]
    public Shape? Shape { get; set; }

}
