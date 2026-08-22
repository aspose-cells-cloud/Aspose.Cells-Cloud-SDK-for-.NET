using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a trendline in a chart.</summary>
public class Trendline : Line
{
    /// <summary>The class has a property named "link" of type "Link" that can be accessed and modified.</summary>
    [JsonPropertyName("link")]
    public Link? Link { get; set; }

    /// <summary>Returns or sets the number of periods (or units on a scatter chart) that the trendline extends backward.</summary>
    [JsonPropertyName("Backward")]
    public double? Backward { get; set; }

    /// <summary>Represents the DataLabels object for the specified series.</summary>
    [JsonPropertyName("DataLabels")]
    public DataLabels? DataLabels { get; set; }

    /// <summary>Represents if the equation for the trendline is displayed on the chart (in the same data label as the R-squared value). Setting this property to True automatically turns on data labels.</summary>
    [JsonPropertyName("DisplayEquation")]
    public bool? DisplayEquation { get; set; }

    /// <summary>Represents if the R-squared value of the trendline is displayed on the chart (in the same data label as the equation). Setting this property to True automatically turns on data labels.</summary>
    [JsonPropertyName("DisplayRSquared")]
    public bool? DisplayRSquared { get; set; }

    /// <summary>Returns or sets the number of periods (or units on a scatter chart) that the trendline extends forward.</summary>
    [JsonPropertyName("Forward")]
    public double? Forward { get; set; }

    /// <summary>Returns or sets the point where the trendline crosses the value axis.</summary>
    [JsonPropertyName("Intercept")]
    public double? Intercept { get; set; }

    /// <summary>Returns if Microsoft Excel automatically determines the name of the trendline.</summary>
    [JsonPropertyName("IsNameAuto")]
    public bool? IsNameAuto { get; set; }

    /// <summary>Gets the legend entry according to this trendline</summary>
    [JsonPropertyName("LegendEntry")]
    public LegendEntry? LegendEntry { get; set; }

    /// <summary>Returns the name of the trendline.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Returns or sets the trendline order (an integer greater than 1) when the trendline type is Polynomial.</summary>
    [JsonPropertyName("Order")]
    public int? Order { get; set; }

    /// <summary>Returns or sets the period for the moving-average trendline.</summary>
    [JsonPropertyName("Period")]
    public int? Period { get; set; }

    /// <summary>Returns the trendline type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

}
