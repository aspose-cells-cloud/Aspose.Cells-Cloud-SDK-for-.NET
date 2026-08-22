using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Row Response.</summary>
public class RowResponse : CellsCloudResponse
{
    /// <summary>This class has a public property named "Row" of type "Row" with both get and set accessors.</summary>
    [JsonPropertyName("Row")]
    public Row? Row { get; set; }

}
