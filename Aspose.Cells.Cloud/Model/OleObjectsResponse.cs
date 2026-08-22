using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the OleObjects Response.</summary>
public class OleObjectsResponse : CellsCloudResponse
{
    /// <summary>Property `OleObjects` of type `OleObjects` that can be accessed and modified publicly within the class.</summary>
    [JsonPropertyName("OleObjects")]
    public OleObjects? OleObjects { get; set; }

}
