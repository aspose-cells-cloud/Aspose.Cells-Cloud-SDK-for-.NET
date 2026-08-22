using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CommentShape Response.</summary>
public class CommentShapeResponse : CellsCloudResponse
{
    /// <summary>The class has a public property named Comment of type CommentShape that can be accessed and modified.</summary>
    [JsonPropertyName("Comment")]
    public CommentShape? Comment { get; set; }

}
