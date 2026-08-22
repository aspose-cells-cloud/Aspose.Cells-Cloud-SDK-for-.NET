using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents the plot area in a chart.</summary>
public class PlotArea : ChartFrame
{
    /// <summary>Gets or sets the height of plot area in units of 1/4000 of the chart area.</summary>
    [JsonPropertyName("InnerHeight")]
    public int? InnerHeight { get; set; }

    /// <summary>Gets or sets the width  of plot area in units of 1/4000 of the chart area.</summary>
    [JsonPropertyName("InnerWidth")]
    public int? InnerWidth { get; set; }

    /// <summary>Gets or gets the x coordinate of the upper top corner of plot area in units of 1/4000 of the chart area.</summary>
    [JsonPropertyName("InnerX")]
    public int? InnerX { get; set; }

    /// <summary>Gets or gets the x coordinate of the upper top corner of plot area in units of 1/4000 of the chart area.</summary>
    [JsonPropertyName("InnerY")]
    public int? InnerY { get; set; }

}
