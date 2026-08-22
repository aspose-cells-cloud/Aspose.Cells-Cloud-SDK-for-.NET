using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a single point in a series in a chart.</summary>
public class ChartPoint : LinkElement
{
    /// <summary>Gets the area.</summary>
    [JsonPropertyName("Area")]
    public Area? Area { get; set; }

    /// <summary>Gets the border.</summary>
    [JsonPropertyName("Border")]
    public Line? Border { get; set; }

    /// <summary>Returns a DataLabels object that represents the data label associated with the point.</summary>
    [JsonPropertyName("DataLabels")]
    public DataLabels? DataLabels { get; set; }

    /// <summary>The distance of an open pie slice from the center of the pie chart is expressed as a percentage of the pie diameter.</summary>
    [JsonPropertyName("Explosion")]
    public int? Explosion { get; set; }

    /// <summary>Gets the marker.</summary>
    [JsonPropertyName("Marker")]
    public Marker? Marker { get; set; }

    /// <summary>True if the chartpoint has a shadow.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

    /// <summary>Gets or sets the X value of the chart point.</summary>
    [JsonPropertyName("XValue")]
    public object? XValue { get; set; }

    /// <summary>Gets or sets the Y value of the chart point.</summary>
    [JsonPropertyName("YValue")]
    public object? YValue { get; set; }

    /// <summary>Gets or sets a value indicates whether this data points is in the second pie or bar on a pie of pie or bar of pie chart.</summary>
    [JsonPropertyName("IsInSecondaryPlot")]
    public bool? IsInSecondaryPlot { get; set; }

}
