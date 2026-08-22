using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Walls Response.</summary>
public class WallsResponse : CellsCloudResponse
{
    /// <summary>The class has a public property named `Walls` of type `Walls`.</summary>
    [JsonPropertyName("Walls")]
    public Walls? Walls { get; set; }

}
