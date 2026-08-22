using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of  objects.</summary>
public class Comments : LinkElement
{
    /// <summary>Property Summary: The CommentList property is annotated to be serialized as XML elements under the tag "comment" and holds a collection of LinkElement objects.</summary>
    [JsonPropertyName("CommentList")]
    public List<LinkElement>? CommentList { get; set; }

}
