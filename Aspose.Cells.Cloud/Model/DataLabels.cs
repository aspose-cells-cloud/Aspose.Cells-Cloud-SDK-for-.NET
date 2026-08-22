using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of all the DataLabel objects for the specified Series.</summary>
public class DataLabels : ChartFrame
{
    /// <summary>Indicates the text is auto generated.</summary>
    [JsonPropertyName("IsAutoText")]
    public bool? IsAutoText { get; set; }

    /// <summary>A nullable boolean property "IsDeleted" indicating whether an object has been deleted.</summary>
    [JsonPropertyName("IsDeleted")]
    public bool? IsDeleted { get; set; }

    /// <summary>Gets or sets the LinkedSource.</summary>
    [JsonPropertyName("LinkedSource")]
    public string? LinkedSource { get; set; }

    /// <summary>Gets and sets the built-in number format.</summary>
    [JsonPropertyName("Number")]
    public int? Number { get; set; }

    /// <summary>Represents the format string for the DataLabels object.</summary>
    [JsonPropertyName("NumberFormat")]
    public string? NumberFormat { get; set; }

    /// <summary>True if the number format is linked to the cells</summary>
    [JsonPropertyName("NumberFormatLinked")]
    public bool? NumberFormatLinked { get; set; }

    /// <summary>Represents the position of the data label.</summary>
    [JsonPropertyName("Position")]
    public string? Position { get; set; }

    /// <summary>Gets or sets the RotationAngle.</summary>
    [JsonPropertyName("RotationAngle")]
    public int? RotationAngle { get; set; }

    /// <summary>Gets or sets the separator type used for the data labels on a chart.</summary>
    [JsonPropertyName("Separator")]
    public string? Separator { get; set; }

    /// <summary>Represents a specified chart's data label percentage value display behavior. True displays the percentage value. False to hide.</summary>
    [JsonPropertyName("ShowBubbleSize")]
    public bool? ShowBubbleSize { get; set; }

    /// <summary>Represents a specified chart's data label category name display behavior.True to display the category name for the data labels on a chart. False to hide.</summary>
    [JsonPropertyName("ShowCategoryName")]
    public bool? ShowCategoryName { get; set; }

    /// <summary>Represents a specified chart's data label legend key display behavior.</summary>
    [JsonPropertyName("ShowLegendKey")]
    public bool? ShowLegendKey { get; set; }

    /// <summary>Represents a specified chart's data label percentage value display behavior. True displays the percentage value. False to hide.</summary>
    [JsonPropertyName("ShowPercentage")]
    public bool? ShowPercentage { get; set; }

    /// <summary>Returns or sets a Boolean to indicate the series name display behavior for the data labels on a chart.</summary>
    [JsonPropertyName("ShowSeriesName")]
    public bool? ShowSeriesName { get; set; }

    /// <summary>Represents a specified chart's data label values display behavior. True displays the values. False to hide.</summary>
    [JsonPropertyName("ShowValue")]
    public bool? ShowValue { get; set; }

    /// <summary>Gets or sets the text of data label.</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

    /// <summary>Gets or sets the TextDirection.</summary>
    [JsonPropertyName("TextDirection")]
    public string? TextDirection { get; set; }

    /// <summary>Gets or sets the TextHorizontalAlignment.</summary>
    [JsonPropertyName("TextHorizontalAlignment")]
    public string? TextHorizontalAlignment { get; set; }

    /// <summary>Gets or sets the TextVerticalAlignment.</summary>
    [JsonPropertyName("TextVerticalAlignment")]
    public string? TextVerticalAlignment { get; set; }

}
