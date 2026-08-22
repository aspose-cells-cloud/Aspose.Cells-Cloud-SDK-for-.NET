using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of Aspose.Cells.Charts.SparklineGroup objects.</summary>
public class SparklineGroups
{
    /// <summary>Encapsulates a collection of Aspose.Cells.Charts.SparklineGroup objects.</summary>
    [JsonPropertyName("SparklineGroupList")]
    public List<SparklineGroup>? SparklineGroupList { get; set; }

}
