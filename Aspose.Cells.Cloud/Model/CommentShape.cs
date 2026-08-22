using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the shape of the comment.</summary>
public class CommentShape : Shape
{
    /// <summary>Gets the comment object.</summary>
    [JsonPropertyName("Comment")]
    public LinkElement? Comment { get; set; }

}
