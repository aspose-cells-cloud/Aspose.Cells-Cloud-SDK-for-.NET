using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a single data series in a chart.</summary>
public class Series : LinkElement
{
    /// <summary>Represents the background area of Series object.</summary>
    [JsonPropertyName("Area")]
    public Area? Area { get; set; }

    /// <summary>Gets or sets the 3D shape type used with the 3-D bar or column chart.</summary>
    [JsonPropertyName("Bar3DShapeType")]
    public string? Bar3DShapeType { get; set; }

    /// <summary>Represents border of Series object.</summary>
    [JsonPropertyName("Border")]
    public Line? Border { get; set; }

    /// <summary>Gets or sets the scale factor for bubbles in the specified chart group.</summary>
    [JsonPropertyName("BubbleScale")]
    public int? BubbleScale { get; set; }

    /// <summary>Gets or sets the bubble sizes values of the chart series.</summary>
    [JsonPropertyName("BubbleSizes")]
    public string? BubbleSizes { get; set; }

    /// <summary>Gets the number of the data values.</summary>
    [JsonPropertyName("CountOfDataValues")]
    public int? CountOfDataValues { get; set; }

    /// <summary>Represents the DataLabels object for the specified ASeries.</summary>
    [JsonPropertyName("DataLabels")]
    public DataLabels? DataLabels { get; set; }

    /// <summary>Gets the series's name that displays on the chart graph.</summary>
    [JsonPropertyName("DisplayName")]
    public string? DisplayName { get; set; }

    /// <summary>Returns or sets the size of the hole in a doughnut chart group.</summary>
    [JsonPropertyName("DoughnutHoleSize")]
    public int? DoughnutHoleSize { get; set; }

    /// <summary>Returns a  object that represents the down bars on a line chart.</summary>
    [JsonPropertyName("DownBars")]
    public DropBars? DownBars { get; set; }

    /// <summary>Returns a  object that represents the drop lines for a series on the line chart or area chart.</summary>
    [JsonPropertyName("DropLines")]
    public Line? DropLines { get; set; }

    /// <summary>The distance of an open pie slice from the center of the pie chart is expressed as a percentage of the pie diameter.</summary>
    [JsonPropertyName("Explosion")]
    public int? Explosion { get; set; }

    /// <summary>Gets or sets the angle of the first pie-chart or doughnut-chart slice, in degrees (clockwise from vertical).</summary>
    [JsonPropertyName("FirstSliceAngle")]
    public int? FirstSliceAngle { get; set; }

    /// <summary>Returns or sets the space between bar or column clusters, as a percentage of the bar or column width.</summary>
    [JsonPropertyName("GapWidth")]
    public int? GapWidth { get; set; }

    /// <summary>True if the series has a three-dimensional appearance.</summary>
    [JsonPropertyName("Has3DEffect")]
    public bool? Has3DEffect { get; set; }

    /// <summary>True if the chart has drop lines.</summary>
    [JsonPropertyName("HasDropLines")]
    public bool? HasDropLines { get; set; }

    /// <summary>True if the line chart has high-low lines.</summary>
    [JsonPropertyName("HasHiLoLines")]
    public bool? HasHiLoLines { get; set; }

    /// <summary>True if the series has leader lines.</summary>
    [JsonPropertyName("HasLeaderLines")]
    public bool? HasLeaderLines { get; set; }

    /// <summary>True if a radar chart has category axis labels. Applies only to radar charts.</summary>
    [JsonPropertyName("HasRadarAxisLabels")]
    public bool? HasRadarAxisLabels { get; set; }

    /// <summary>True if a stacked column chart or bar chart has series lines or</summary>
    [JsonPropertyName("HasSeriesLines")]
    public bool? HasSeriesLines { get; set; }

    /// <summary>True if a line chart has up and down bars.</summary>
    [JsonPropertyName("HasUpDownBars")]
    public bool? HasUpDownBars { get; set; }

    /// <summary>Returns a HiLoLines object that represents the high-low lines for a series on a line chart.</summary>
    [JsonPropertyName("HiLoLines")]
    public Line? HiLoLines { get; set; }

    /// <summary>Indicates whether the threshold value is automatic.</summary>
    [JsonPropertyName("IsAutoSplit")]
    public bool? IsAutoSplit { get; set; }

    /// <summary>Represents if the color of points is varied.</summary>
    [JsonPropertyName("IsColorVaried")]
    public bool? IsColorVaried { get; set; }

    /// <summary>Represents leader lines on a chart. Leader lines connect data labels to data points.</summary>
    [JsonPropertyName("LeaderLines")]
    public Line? LeaderLines { get; set; }

    /// <summary>Gets the legend entry according to this series.</summary>
    [JsonPropertyName("LegendEntry")]
    public LegendEntry? LegendEntry { get; set; }

    /// <summary>Gets the marker.</summary>
    [JsonPropertyName("Marker")]
    public Marker? Marker { get; set; }

    /// <summary>Gets or sets the name of the data series.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Specifies how bars and columns are positioned.</summary>
    [JsonPropertyName("Overlap")]
    public int? Overlap { get; set; }

    /// <summary>Indicates if this series is plotted on second value axis.</summary>
    [JsonPropertyName("PlotOnSecondAxis")]
    public bool? PlotOnSecondAxis { get; set; }

    /// <summary>Gets the collection of points in a series in a chart.</summary>
    [JsonPropertyName("Points")]
    public LinkElement? Points { get; set; }

    /// <summary>Returns or sets the size of the secondary section of either a pie of pie chart or a bar of pie chart,</summary>
    [JsonPropertyName("SecondPlotSize")]
    public int? SecondPlotSize { get; set; }

    /// <summary>Returns a SeriesLines object that represents the series lines for a stacked bar chart or a stacked column chart.</summary>
    [JsonPropertyName("SeriesLines")]
    public Line? SeriesLines { get; set; }

    /// <summary>True if the series has a shadow.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

    /// <summary>True if negative bubbles are shown for the chart group. Valid only for bubble charts.</summary>
    [JsonPropertyName("ShowNegativeBubbles")]
    public bool? ShowNegativeBubbles { get; set; }

    /// <summary>Gets or sets what the bubble size represents on a bubble chart.</summary>
    [JsonPropertyName("SizeRepresents")]
    public string? SizeRepresents { get; set; }

    /// <summary>Represents curve smoothing.</summary>
    [JsonPropertyName("Smooth")]
    public bool? Smooth { get; set; }

    /// <summary>Returns or sets a value that how to determine which data points are in the second pie or bar on a pie of pie or bar of</summary>
    [JsonPropertyName("SplitType")]
    public string? SplitType { get; set; }

    /// <summary>Returns or sets a value that shall be used to determine which data points are in the second pie or bar on</summary>
    [JsonPropertyName("SplitValue")]
    public double? SplitValue { get; set; }

    /// <summary>Returns an object that represents a collection of all the trendlines for the series.</summary>
    [JsonPropertyName("TrendLines")]
    public Trendlines? TrendLines { get; set; }

    /// <summary>Gets or sets a data series' type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Returns an DropBars object that represents the up bars on a line chart.</summary>
    [JsonPropertyName("UpBars")]
    public DropBars? UpBars { get; set; }

    /// <summary>Represents the data of the chart series.</summary>
    [JsonPropertyName("Values")]
    public string? Values { get; set; }

    /// <summary>Represents X direction error bar of the series.</summary>
    [JsonPropertyName("XErrorBar")]
    public ErrorBar? XErrorBar { get; set; }

    /// <summary>Represents the x values of the chart series.</summary>
    [JsonPropertyName("XValues")]
    public string? XValues { get; set; }

    /// <summary>Represents Y direction error bar of the series.</summary>
    [JsonPropertyName("YErrorBar")]
    public ErrorBar? YErrorBar { get; set; }

}
