using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a legend entry in a chart legend.</summary>
public class LegendEntry : LinkElement
{
    /// <summary>True if the text in the object changes font size when the object size changes.</summary>
    [JsonPropertyName("AutoScaleFont")]
    public bool? AutoScaleFont { get; set; }

    /// <summary>Gets and sets the display mode of the background</summary>
    [JsonPropertyName("BackgroundMode")]
    public string? BackgroundMode { get; set; }

    /// <summary>Gets a  object of the specified ChartFrame object.</summary>
    [JsonPropertyName("Font")]
    public Font? Font { get; set; }

    /// <summary>Gets and sets whether the legend entry is deleted.</summary>
    [JsonPropertyName("IsDeleted")]
    public bool? IsDeleted { get; set; }

}
