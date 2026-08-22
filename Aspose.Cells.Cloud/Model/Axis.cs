using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents an axis of chart.</summary>
public class Axis : LinkElement
{
    /// <summary>Gets the .</summary>
    [JsonPropertyName("Area")]
    public Area? Area { get; set; }

    /// <summary>Represents if the value axis crosses the category axis between categories.</summary>
    [JsonPropertyName("AxisBetweenCategories")]
    public bool? AxisBetweenCategories { get; set; }

    /// <summary>Gets the appearance of an Axis.</summary>
    [JsonPropertyName("AxisLine")]
    public Line? AxisLine { get; set; }

    /// <summary>Represents the base unit scale for the category axis.</summary>
    [JsonPropertyName("BaseUnitScale")]
    public string? BaseUnitScale { get; set; }

    /// <summary>Represents the category axis type.</summary>
    [JsonPropertyName("CategoryType")]
    public string? CategoryType { get; set; }

    /// <summary>Represents the point on the value axis where the category axis crosses it.</summary>
    [JsonPropertyName("CrossAt")]
    public double? CrossAt { get; set; }

    /// <summary>Represents the  on the specified axis where the other axis crosses.</summary>
    [JsonPropertyName("CrossType")]
    public string? CrossType { get; set; }

    /// <summary>Represents the unit label for the specified axis.</summary>
    [JsonPropertyName("DisplayUnit")]
    public string? DisplayUnit { get; set; }

    /// <summary>Represents a unit label on an axis in the specified chart.</summary>
    [JsonPropertyName("DisplayUnitLabel")]
    public DisplayUnitLabel? DisplayUnitLabel { get; set; }

    /// <summary>Indicates whether the labels shall be shown as multi level.</summary>
    [JsonPropertyName("HasMultiLevelLabels")]
    public bool? HasMultiLevelLabels { get; set; }

    /// <summary>Indicates whether the major unit of the axis is automatically assigned.</summary>
    [JsonPropertyName("IsAutomaticMajorUnit")]
    public bool? IsAutomaticMajorUnit { get; set; }

    /// <summary>Indicates whether the max value is automatically assigned.</summary>
    [JsonPropertyName("IsAutomaticMaxValue")]
    public bool? IsAutomaticMaxValue { get; set; }

    /// <summary>Indicates whether the minor unit of the axis is automatically assigned.</summary>
    [JsonPropertyName("IsAutomaticMinorUnit")]
    public bool? IsAutomaticMinorUnit { get; set; }

    /// <summary>Indicates whether the min value is automatically assigned.</summary>
    [JsonPropertyName("IsAutomaticMinValue")]
    public bool? IsAutomaticMinValue { get; set; }

    /// <summary>Represents if the display unit label is shown on the specified axis.</summary>
    [JsonPropertyName("IsDisplayUnitLabelShown")]
    public bool? IsDisplayUnitLabelShown { get; set; }

    /// <summary>Represents if the value axis scale type is logarithmic or not.</summary>
    [JsonPropertyName("IsLogarithmic")]
    public bool? IsLogarithmic { get; set; }

    /// <summary>Represents if Microsoft Excel plots data points from last to first.</summary>
    [JsonPropertyName("IsPlotOrderReversed")]
    public bool? IsPlotOrderReversed { get; set; }

    /// <summary>Represents if the axis is visible.</summary>
    [JsonPropertyName("IsVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>Represents the logarithmic base. Default value is 10.Only applies for Excel2007.</summary>
    [JsonPropertyName("LogBase")]
    public double? LogBase { get; set; }

    /// <summary>Represents major gridlines on a chart axis.</summary>
    [JsonPropertyName("MajorGridLines")]
    public Line? MajorGridLines { get; set; }

    /// <summary>Represents the type of major tick mark for the specified axis.</summary>
    [JsonPropertyName("MajorTickMark")]
    public string? MajorTickMark { get; set; }

    /// <summary>Represents the major units for the axis.</summary>
    [JsonPropertyName("MajorUnit")]
    public double? MajorUnit { get; set; }

    /// <summary>Represents the major unit scale for the category axis.</summary>
    [JsonPropertyName("MajorUnitScale")]
    public string? MajorUnitScale { get; set; }

    /// <summary>Represents the maximum value on the value axis.</summary>
    [JsonPropertyName("MaxValue")]
    public double? MaxValue { get; set; }

    /// <summary>Represents minor gridlines on a chart axis.</summary>
    [JsonPropertyName("MinorGridLines")]
    public Line? MinorGridLines { get; set; }

    /// <summary>Represents the type of minor tick mark for the specified axis.</summary>
    [JsonPropertyName("MinorTickMark")]
    public string? MinorTickMark { get; set; }

    /// <summary>Represents the minor units for the axis.</summary>
    [JsonPropertyName("MinorUnit")]
    public double? MinorUnit { get; set; }

    /// <summary>Represents the major unit scale for the category axis.</summary>
    [JsonPropertyName("MinorUnitScale")]
    public string? MinorUnitScale { get; set; }

    /// <summary>Represents the minimum value on the value axis.</summary>
    [JsonPropertyName("MinValue")]
    public double? MinValue { get; set; }

    /// <summary>Represents the position of tick-mark labels on the specified axis.</summary>
    [JsonPropertyName("TickLabelPosition")]
    public string? TickLabelPosition { get; set; }

    /// <summary>Returns a  object that represents the tick-mark labels for the specified axis.</summary>
    [JsonPropertyName("TickLabels")]
    public TickLabels? TickLabels { get; set; }

    /// <summary>Represents the number of categories or series between tick-mark labels. Applies only to category and series axes.</summary>
    [JsonPropertyName("TickLabelSpacing")]
    public int? TickLabelSpacing { get; set; }

    /// <summary>Returns or sets the number of categories or series between tick marks. Applies only to category and series axes.</summary>
    [JsonPropertyName("TickMarkSpacing")]
    public int? TickMarkSpacing { get; set; }

    /// <summary>Gets the axis' title.</summary>
    [JsonPropertyName("Title")]
    public Title? Title { get; set; }

}
