using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CellsDrawing Response.</summary>
public class CellsDrawingResponse : CellsCloudResponse
{
    /// <summary>This class has a public property named Shape of type CellsDrawing.</summary>
    [JsonPropertyName("Shape")]
    public CellsDrawing? Shape { get; set; }

}
