using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the OleObject Response.</summary>
public class OleObjectResponse : CellsCloudResponse
{
    /// <summary>This class has a property named OleObject of type OleObject with both read and write capabilities.</summary>
    [JsonPropertyName("OleObject")]
    public OleObject? OleObject { get; set; }

}
