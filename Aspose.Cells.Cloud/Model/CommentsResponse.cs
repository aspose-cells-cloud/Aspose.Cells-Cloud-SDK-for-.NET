using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Comments Response.</summary>
public class CommentsResponse : CellsCloudResponse
{
    /// <summary>Property Summary: "The Comments property represents an XML element named 'comments' within the class."</summary>
    [JsonPropertyName("Comments")]
    public Comments? Comments { get; set; }

}
