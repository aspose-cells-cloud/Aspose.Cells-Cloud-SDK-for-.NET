using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a single Excel chart.</summary>
public class Chart : LinkElement
{
    /// <summary>True if Microsoft Excel scales a 3-D chart so that it's closer in size to the equivalent 2-D chart.</summary>
    [JsonPropertyName("AutoScaling")]
    public bool? AutoScaling { get; set; }

    /// <summary>Returns a  object that represents the back wall of a 3-D chart.</summary>
    [JsonPropertyName("BackWall")]
    public Walls? BackWall { get; set; }

    /// <summary>Gets the chart's X axis.</summary>
    [JsonPropertyName("CategoryAxis")]
    public Axis? CategoryAxis { get; set; }

    /// <summary>Gets the chart area in the worksheet.</summary>
    [JsonPropertyName("ChartArea")]
    public ChartArea? ChartArea { get; set; }

    /// <summary>Represents the chart data table.</summary>
    [JsonPropertyName("ChartDataTable")]
    public ChartDataTable? ChartDataTable { get; set; }

    /// <summary>Represents the chartShape;</summary>
    [JsonPropertyName("ChartObject")]
    public LinkElement? ChartObject { get; set; }

    /// <summary>Represents the depth of a 3-D chart as a percentage of the chart width (between 20 and 2000 percent).</summary>
    [JsonPropertyName("DepthPercent")]
    public int? DepthPercent { get; set; }

    /// <summary>Represents the elevation of the 3-D chart view, in degrees.</summary>
    [JsonPropertyName("Elevation")]
    public int? Elevation { get; set; }

    /// <summary>Gets or sets the angle of the first pie-chart or doughnut-chart slice, in degrees (clockwise from vertical).</summary>
    [JsonPropertyName("FirstSliceAngle")]
    public int? FirstSliceAngle { get; set; }

    /// <summary>Returns a  object that represents the walls of a 3-D chart.</summary>
    [JsonPropertyName("Floor")]
    public Floor? Floor { get; set; }

    /// <summary>Gets or sets the distance between the data series in a 3-D chart, as a percentage of the marker width.</summary>
    [JsonPropertyName("GapDepth")]
    public int? GapDepth { get; set; }

    /// <summary>Returns or sets the space between bar or column clusters, as a percentage of the bar or column width.</summary>
    [JsonPropertyName("GapWidth")]
    public int? GapWidth { get; set; }

    /// <summary>Returns or sets the height of a 3-D chart as a percentage of the chart width (between 5 and 500 percent).</summary>
    [JsonPropertyName("HeightPercent")]
    public int? HeightPercent { get; set; }

    /// <summary>Indicates whether hide the pivot chart field buttons only when the chart is PivotChart.</summary>
    [JsonPropertyName("HidePivotFieldButtons")]
    public bool? HidePivotFieldButtons { get; set; }

    /// <summary>Indicates whether the chart is a 3d chart.</summary>
    [JsonPropertyName("Is3D")]
    public bool? Is3D { get; set; }

    /// <summary>Gets or sets a value indicating whether the chart area is rectangular cornered.</summary>
    [JsonPropertyName("IsRectangularCornered")]
    public bool? IsRectangularCornered { get; set; }

    /// <summary>Gets the chart legend.</summary>
    [JsonPropertyName("Legend")]
    public Legend? Legend { get; set; }

    /// <summary>Represents chart name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets a  collection representing the data series in the chart.</summary>
    [JsonPropertyName("NSeries")]
    public SeriesItems? NSeries { get; set; }

    /// <summary>Represents the page setup description in this chart.</summary>
    [JsonPropertyName("PageSetup")]
    public LinkElement? PageSetup { get; set; }

    /// <summary>Returns or sets the perspective for the 3-D chart view. Must be between 0 and 100.</summary>
    [JsonPropertyName("Perspective")]
    public int? Perspective { get; set; }

    /// <summary>The source is the data of the pivotTable.</summary>
    [JsonPropertyName("PivotSource")]
    public string? PivotSource { get; set; }

    /// <summary>Represents the way the chart is attached to the cells below it.</summary>
    [JsonPropertyName("Placement")]
    public string? Placement { get; set; }

    /// <summary>Gets the chart's plot area which includes axis tick labels.</summary>
    [JsonPropertyName("PlotArea")]
    public PlotArea? PlotArea { get; set; }

    /// <summary>Gets and sets  how to plot the empty cells.</summary>
    [JsonPropertyName("PlotEmptyCellsType")]
    public string? PlotEmptyCellsType { get; set; }

    /// <summary>Indicates whether only plot visible cells.</summary>
    [JsonPropertyName("PlotVisibleCells")]
    public bool? PlotVisibleCells { get; set; }

    /// <summary>Gets and sets the printed chart size.</summary>
    [JsonPropertyName("PrintSize")]
    public string? PrintSize { get; set; }

    /// <summary>True if the chart axes are at right angles. Applies only for 3-D charts(except Column3D and 3-D Pie Charts).</summary>
    [JsonPropertyName("RightAngleAxes")]
    public bool? RightAngleAxes { get; set; }

    /// <summary>Represents the rotation of the 3-D chart view (the rotation of the plot area around the z-axis, in degrees).</summary>
    [JsonPropertyName("RotationAngle")]
    public int? RotationAngle { get; set; }

    /// <summary>Gets the chart's second X axis.</summary>
    [JsonPropertyName("SecondCategoryAxis")]
    public LinkElement? SecondCategoryAxis { get; set; }

    /// <summary>Gets the chart's second Y axis.</summary>
    [JsonPropertyName("SecondValueAxis")]
    public LinkElement? SecondValueAxis { get; set; }

    /// <summary>Gets the chart's series axis.</summary>
    [JsonPropertyName("SeriesAxis")]
    public LinkElement? SeriesAxis { get; set; }

    /// <summary>Returns all drawing shapes in this chart.</summary>
    [JsonPropertyName("Shapes")]
    public LinkElement? Shapes { get; set; }

    /// <summary>Gets or sets a value indicating whether the chart displays a data table.</summary>
    [JsonPropertyName("ShowDataTable")]
    public bool? ShowDataTable { get; set; }

    /// <summary>Gets or sets a value indicating whether the chart legend will be displayed. Default is true.</summary>
    [JsonPropertyName("ShowLegend")]
    public bool? ShowLegend { get; set; }

    /// <summary>Returns a  object that represents the side wall of a 3-D chart.</summary>
    [JsonPropertyName("SideWall")]
    public LinkElement? SideWall { get; set; }

    /// <summary>True if Microsoft Excel resizes the chart to match the size of the chart sheet window.</summary>
    [JsonPropertyName("SizeWithWindow")]
    public bool? SizeWithWindow { get; set; }

    /// <summary>Gets and sets the builtin style.</summary>
    [JsonPropertyName("Style")]
    public int? Style { get; set; }

    /// <summary>Represents chart title.</summary>
    [JsonPropertyName("Title")]
    public LinkElement? Title { get; set; }

    /// <summary>Represents chart type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets the chart's Y axis.</summary>
    [JsonPropertyName("ValueAxis")]
    public Axis? ValueAxis { get; set; }

    /// <summary>Returns a  object that represents the walls of a 3-D chart.</summary>
    [JsonPropertyName("Walls")]
    public LinkElement? Walls { get; set; }

    /// <summary>True if gridlines are drawn two-dimensionally on a 3-D chart.</summary>
    [JsonPropertyName("WallsAndGridlines2D")]
    public bool? WallsAndGridlines2D { get; set; }

}
