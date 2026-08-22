using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents the chart legend.</summary>
public class Legend : ChartFrame
{
    /// <summary>Gets or sets the legend position type.</summary>
    [JsonPropertyName("Position")]
    public string? Position { get; set; }

    /// <summary>Gets a collection of all the LegendEntry objects in the specified chart legend.</summary>
    [JsonPropertyName("LegendEntries")]
    public LinkElement? LegendEntries { get; set; }

}
