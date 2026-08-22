using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Title Response.</summary>
public class TitleResponse : CellsCloudResponse
{
    /// <summary>This class has a property called "Title" of type "Title" with both a getter and a setter.</summary>
    [JsonPropertyName("Title")]
    public Title? Title { get; set; }

}
