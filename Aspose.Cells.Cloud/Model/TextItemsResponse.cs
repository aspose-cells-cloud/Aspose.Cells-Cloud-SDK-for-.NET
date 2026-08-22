using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the TextItems Response.</summary>
public class TextItemsResponse : CellsCloudResponse
{
    /// <summary>This property allows access to a collection of TextItems.</summary>
    [JsonPropertyName("TextItems")]
    public TextItems? TextItems { get; set; }

}
