using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ListObject Response.</summary>
public class ListObjectResponse : CellsCloudResponse
{
    /// <summary>A property that represents a list object within the Tables class.</summary>
    [JsonPropertyName("ListObject")]
    public ListObject? ListObject { get; set; }

}
