using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Describe the DataBar conditional formatting rule. This conditional formatting</summary>
public class DataBar
{
    /// <summary>Gets the color of the axis for cells with conditional formatting as data bars.</summary>
    [JsonPropertyName("AxisColor")]
    public Color? AxisColor { get; set; }

    /// <summary>Gets or sets the position of the axis of the data bars specified by a conditional formatting rule.</summary>
    [JsonPropertyName("AxisPosition")]
    public string? AxisPosition { get; set; }

    /// <summary>Gets an object that specifies the border of a data bar.</summary>
    [JsonPropertyName("BarBorder")]
    public DataBarBorder? BarBorder { get; set; }

    /// <summary>Gets or sets how a data bar is filled with color.</summary>
    [JsonPropertyName("BarFillType")]
    public string? BarFillType { get; set; }

    /// <summary>Get or set this DataBar's Color.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>Gets or sets the direction the databar is displayed.</summary>
    [JsonPropertyName("Direction")]
    public string? Direction { get; set; }

    /// <summary>Get or set this DataBar's max value object.</summary>
    [JsonPropertyName("MaxCfvo")]
    public ConditionalFormattingValue? MaxCfvo { get; set; }

    /// <summary>Represents the max length of data bar .</summary>
    [JsonPropertyName("MaxLength")]
    public int? MaxLength { get; set; }

    /// <summary>Get or set this DataBar's min value object.</summary>
    [JsonPropertyName("MinCfvo")]
    public ConditionalFormattingValue? MinCfvo { get; set; }

    /// <summary>Represents the min length of data bar .</summary>
    [JsonPropertyName("MinLength")]
    public int? MinLength { get; set; }

    /// <summary>Gets the NegativeBarFormat object associated with a data bar conditional formatting rule.</summary>
    [JsonPropertyName("NegativeBarFormat")]
    public NegativeBarFormat? NegativeBarFormat { get; set; }

    /// <summary>Get or set the flag indicating whether to show the values of the cells on which this data bar is applied.</summary>
    [JsonPropertyName("ShowValue")]
    public bool? ShowValue { get; set; }

}
