using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ListObjects Response.</summary>
public class ListObjectsResponse : CellsCloudResponse
{
    /// <summary>A property named "ListObjects" of type "Tables.ListObjects" that can be both accessed and modified.</summary>
    [JsonPropertyName("ListObjects")]
    public ListObjects? ListObjects { get; set; }

}
