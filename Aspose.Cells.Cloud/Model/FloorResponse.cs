using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Floor Response.</summary>
public class FloorResponse : CellsCloudResponse
{
    /// <summary>This class has a public property "Floor" of type "Floor" with both a getter and a setter.</summary>
    [JsonPropertyName("Floor")]
    public Floor? Floor { get; set; }

}
