using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the LineShape Response.</summary>
public class LineShapeResponse : CellsCloudResponse
{
    /// <summary>The class has a public property called Shape of type LineShape that can be both accessed and modified.</summary>
    [JsonPropertyName("Shape")]
    public LineShape? Shape { get; set; }

}
