using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Comment Response.</summary>
public class CommentResponse : CellsCloudResponse
{
    /// <summary>The class has a public property "Comment" of type "Comment" that can be accessed and modified.</summary>
    [JsonPropertyName("Comment")]
    public Comment? Comment { get; set; }

}
