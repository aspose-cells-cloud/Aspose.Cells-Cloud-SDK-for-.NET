using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents the line format.</summary>
public class Line
{
    /// <summary>Specifies the length of the arrowhead for the begin of a line.</summary>
    [JsonPropertyName("BeginArrowLength")]
    public string? BeginArrowLength { get; set; }

    /// <summary>Specifies the width of the arrowhead for the begin of a line.</summary>
    [JsonPropertyName("BeginArrowWidth")]
    public string? BeginArrowWidth { get; set; }

    /// <summary>Specifies an arrowhead for the begin of a line.</summary>
    [JsonPropertyName("BeginType")]
    public string? BeginType { get; set; }

    /// <summary>Specifies the ending caps.</summary>
    [JsonPropertyName("CapType")]
    public string? CapType { get; set; }

    /// <summary>Represents the  of the line.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>Specifies the compound line type</summary>
    [JsonPropertyName("CompoundType")]
    public string? CompoundType { get; set; }

    /// <summary>Specifies the dash line type</summary>
    [JsonPropertyName("DashType")]
    public string? DashType { get; set; }

    /// <summary>Specifies the length of the arrowhead for the end of a line.</summary>
    [JsonPropertyName("EndArrowLength")]
    public string? EndArrowLength { get; set; }

    /// <summary>Specifies the width of the arrowhead for the end of a line.</summary>
    [JsonPropertyName("EndArrowWidth")]
    public string? EndArrowWidth { get; set; }

    /// <summary>Specifies an arrowhead for the end of a line.</summary>
    [JsonPropertyName("EndType")]
    public string? EndType { get; set; }

    /// <summary>Represents gradient fill.</summary>
    [JsonPropertyName("GradientFill")]
    public GradientFill? GradientFill { get; set; }

    /// <summary>Indicates whether this line style is auto assigned.</summary>
    [JsonPropertyName("IsAuto")]
    public bool? IsAuto { get; set; }

    /// <summary>Indicates whether the color of line is automatic assigned.</summary>
    [JsonPropertyName("IsAutomaticColor")]
    public bool? IsAutomaticColor { get; set; }

    /// <summary>Represents whether the line is visible.</summary>
    [JsonPropertyName("IsVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>Specifies the joining caps.</summary>
    [JsonPropertyName("JoinType")]
    public string? JoinType { get; set; }

    /// <summary>Represents the style of the line.</summary>
    [JsonPropertyName("Style")]
    public string? Style { get; set; }

    /// <summary>Returns or sets the degree of transparency of the line as a value from 0.0 (opaque) through 1.0 (clear).</summary>
    [JsonPropertyName("Transparency")]
    public double? Transparency { get; set; }

    /// <summary>Gets or sets the  of the line.</summary>
    [JsonPropertyName("Weight")]
    public string? Weight { get; set; }

    /// <summary>Gets or sets the weight of the line in unit of points.</summary>
    [JsonPropertyName("WeightPt")]
    public double? WeightPt { get; set; }

}
