using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents the frame object in a chart.</summary>
public class ChartFrame
{
    /// <summary>Gets the area.</summary>
    [JsonPropertyName("Area")]
    public Area? Area { get; set; }

    /// <summary>True if the text in the object changes font size when the object size changes. The default value is True.</summary>
    [JsonPropertyName("AutoScaleFont")]
    public bool? AutoScaleFont { get; set; }

    /// <summary>Gets and sets the display mode of the background</summary>
    [JsonPropertyName("BackgroundMode")]
    public string? BackgroundMode { get; set; }

    /// <summary>Gets the border.</summary>
    [JsonPropertyName("Border")]
    public Line? Border { get; set; }

    /// <summary>Gets a  object of the specified ChartFrame object.</summary>
    [JsonPropertyName("Font")]
    public Font? Font { get; set; }

    /// <summary>Indicates whether the chart frame is automatic sized.</summary>
    [JsonPropertyName("IsAutomaticSize")]
    public bool? IsAutomaticSize { get; set; }

    /// <summary>Indicates whether the size of the plot area size includes the tick marks, and the axis labels.</summary>
    [JsonPropertyName("IsInnerMode")]
    public bool? IsInnerMode { get; set; }

    /// <summary>True if the frame has a shadow.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

    /// <summary>Gets or sets the width of frame in units of 1/4000 of the chart area.</summary>
    [JsonPropertyName("Width")]
    public int? Width { get; set; }

    /// <summary>Gets or sets the height of frame in units of 1/4000 of the chart area.</summary>
    [JsonPropertyName("Height")]
    public int? Height { get; set; }

    /// <summary>Gets or sets the x coordinate of the upper left corner in units of 1/4000 of the chart area.</summary>
    [JsonPropertyName("X")]
    public int? X { get; set; }

    /// <summary>Gets or sets the y coordinate of the upper left corner in units of 1/4000 of the chart area.</summary>
    [JsonPropertyName("Y")]
    public int? Y { get; set; }

}
