using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>is organized into sparkline group. A SparklineGroup contains a variable number of sparkline items.             A sparkline group specifies the type, display settings and axis settings for the sparklines.</summary>
public class SparklineGroup
{
    /// <summary>Indicates whether to show data in hidden rows and columns.</summary>
    [JsonPropertyName("DisplayHidden")]
    public bool? DisplayHidden { get; set; }

    /// <summary>Gets and sets the color of the first point of data in the sparkline group.</summary>
    [JsonPropertyName("FirstPointColor")]
    public CellsColor? FirstPointColor { get; set; }

    /// <summary>Gets and sets the color of the highest points of data in the sparkline group.</summary>
    [JsonPropertyName("HighPointColor")]
    public CellsColor? HighPointColor { get; set; }

    /// <summary>Gets and sets the color of the horizontal axis in the sparkline group.</summary>
    [JsonPropertyName("HorizontalAxisColor")]
    public CellsColor? HorizontalAxisColor { get; set; }

    /// <summary>Represents the range that contains the date values for the sparkline data.</summary>
    [JsonPropertyName("HorizontalAxisDateRange")]
    public string? HorizontalAxisDateRange { get; set; }

    /// <summary>Gets and sets the color of the last point of data in the sparkline group.</summary>
    [JsonPropertyName("LastPointColor")]
    public CellsColor? LastPointColor { get; set; }

    /// <summary>Gets and sets the line weight in each line sparkline in the sparkline group, in the unit of points.</summary>
    [JsonPropertyName("LineWeight")]
    public double? LineWeight { get; set; }

    /// <summary>Gets and sets the color of the lowest points of data in the sparkline group.</summary>
    [JsonPropertyName("LowPointColor")]
    public CellsColor? LowPointColor { get; set; }

    /// <summary>Gets and sets the color of points in each line sparkline in the sparkline group.</summary>
    [JsonPropertyName("MarkersColor")]
    public CellsColor? MarkersColor { get; set; }

    /// <summary>Gets and sets the color of the negative values on the sparkline group.</summary>
    [JsonPropertyName("NegativePointsColor")]
    public CellsColor? NegativePointsColor { get; set; }

    /// <summary>Indicates how to plot empty cells.</summary>
    [JsonPropertyName("PlotEmptyCellsType")]
    public string? PlotEmptyCellsType { get; set; }

    /// <summary>Indicates whether the plot data is right to left.</summary>
    [JsonPropertyName("PlotRightToLeft")]
    public bool? PlotRightToLeft { get; set; }

    /// <summary>Gets and sets the preset style type of the sparkline group.</summary>
    [JsonPropertyName("PresetStyle")]
    public string? PresetStyle { get; set; }

    /// <summary>Gets and sets the color of the sparklines in the sparkline group.</summary>
    [JsonPropertyName("SeriesColor")]
    public CellsColor? SeriesColor { get; set; }

    /// <summary>Indicates whether to highlight the first point of data in the sparkline group.</summary>
    [JsonPropertyName("ShowFirstPoint")]
    public bool? ShowFirstPoint { get; set; }

    /// <summary>Indicates whether to highlight the highest points of data in the sparkline group.</summary>
    [JsonPropertyName("ShowHighPoint")]
    public bool? ShowHighPoint { get; set; }

    /// <summary>Indicates whether to show the sparkline horizontal axis.</summary>
    [JsonPropertyName("ShowHorizontalAxis")]
    public bool? ShowHorizontalAxis { get; set; }

    /// <summary>Indicates whether to highlight the last point of data in the sparkline group.</summary>
    [JsonPropertyName("ShowLastPoint")]
    public bool? ShowLastPoint { get; set; }

    /// <summary>Indicates whether to highlight the lowest points of data in the sparkline group.</summary>
    [JsonPropertyName("ShowLowPoint")]
    public bool? ShowLowPoint { get; set; }

    /// <summary>Indicates whether to highlight each point in each line sparkline in the sparkline group.</summary>
    [JsonPropertyName("ShowMarkers")]
    public bool? ShowMarkers { get; set; }

    /// <summary>Indicates whether to highlight the negative values on the sparkline group with a different color or marker.</summary>
    [JsonPropertyName("ShowNegativePoints")]
    public bool? ShowNegativePoints { get; set; }

    /// <summary>Gets the collection of  object.</summary>
    [JsonPropertyName("SparklineCollection")]
    public List<Sparkline>? SparklineCollection { get; set; }

    /// <summary>Indicates the sparkline type of the sparkline group.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets and sets the custom maximum value for the vertical axis.</summary>
    [JsonPropertyName("VerticalAxisMaxValue")]
    public double? VerticalAxisMaxValue { get; set; }

    /// <summary>Represents the vertical axis maximum value type.</summary>
    [JsonPropertyName("VerticalAxisMaxValueType")]
    public string? VerticalAxisMaxValueType { get; set; }

    /// <summary>Gets and sets the custom minimum value for the vertical axis.</summary>
    [JsonPropertyName("VerticalAxisMinValue")]
    public double? VerticalAxisMinValue { get; set; }

    /// <summary>Represents the vertical axis minimum value type.</summary>
    [JsonPropertyName("VerticalAxisMinValueType")]
    public string? VerticalAxisMinValueType { get; set; }

}
