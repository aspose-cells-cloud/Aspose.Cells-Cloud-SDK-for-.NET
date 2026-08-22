using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Trendline Response.</summary>
public class TrendlineResponse : CellsCloudResponse
{
    /// <summary>The class has a public property called "Trendline" of type "Trendline" that can be accessed and modified.</summary>
    [JsonPropertyName("Trendline")]
    public Trendline? Trendline { get; set; }

}
