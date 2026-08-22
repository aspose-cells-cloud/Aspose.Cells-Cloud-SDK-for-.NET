using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Trendlines Response.</summary>
public class TrendlinesResponse : CellsCloudResponse
{
    /// <summary>This property allows access to the Trendlines feature and set new values for it.</summary>
    [JsonPropertyName("Trendlines")]
    public Trendlines? Trendlines { get; set; }

}
