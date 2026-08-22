using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the TextItem Response.</summary>
public class TextItemResponse : CellsCloudResponse
{
    /// <summary>The class has a property that allows getting and setting a TextItem object.</summary>
    [JsonPropertyName("TextItem")]
    public TextItem? TextItem { get; set; }

}
