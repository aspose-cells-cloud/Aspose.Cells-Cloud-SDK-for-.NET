using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Line Response.</summary>
public class LineResponse : CellsCloudResponse
{
    /// <summary>A public property named "Line" of type Line with both getter and setter methods.</summary>
    [JsonPropertyName("Line")]
    public Line? Line { get; set; }

}
