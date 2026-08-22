using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SparklineGroups Response.</summary>
public class SparklineGroupsResponse : CellsCloudResponse
{
    /// <summary>This class has a property named "SparklineGroups" of type "SparklineGroups" for managing sparkline groups.</summary>
    [JsonPropertyName("SparklineGroups")]
    public SparklineGroups? SparklineGroups { get; set; }

}
