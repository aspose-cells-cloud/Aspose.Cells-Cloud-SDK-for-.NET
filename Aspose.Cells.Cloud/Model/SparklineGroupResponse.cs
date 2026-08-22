using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SparklineGroup Response.</summary>
public class SparklineGroupResponse : CellsCloudResponse
{
    /// <summary>A property that allows access to a Sparkline group containing multiple Sparkline objects.</summary>
    [JsonPropertyName("SparklineGroup")]
    public SparklineGroup? SparklineGroup { get; set; }

}
