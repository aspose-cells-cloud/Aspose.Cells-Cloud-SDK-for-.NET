using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Cell Response.</summary>
public class CellResponse : CellsCloudResponse
{
    /// <summary>A property named "Cell" of type "Cell" that has both a getter and a setter.</summary>
    [JsonPropertyName("Cell")]
    public Cell? Cell { get; set; }

}
