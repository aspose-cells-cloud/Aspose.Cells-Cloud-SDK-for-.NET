using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a chart data table.</summary>
public class ChartDataTable : LinkElement
{
    /// <summary>True if the text in the object changes font size when the object size changes.</summary>
    [JsonPropertyName("AutoScaleFont")]
    public bool? AutoScaleFont { get; set; }

    /// <summary>Gets and sets the display mode of the background</summary>
    [JsonPropertyName("BackgroundMode")]
    public string? BackgroundMode { get; set; }

    /// <summary>Returns a Border object that represents the border of the object</summary>
    [JsonPropertyName("Border")]
    public Line? Border { get; set; }

    /// <summary>Gets a  object which represents the font setting of the specified chart data table.</summary>
    [JsonPropertyName("Font")]
    public Font? Font { get; set; }

    /// <summary>True if the chart data table has horizontal cell borders</summary>
    [JsonPropertyName("HasBorderHorizontal")]
    public bool? HasBorderHorizontal { get; set; }

    /// <summary>True if the chart data table has outline borders</summary>
    [JsonPropertyName("HasBorderOutline")]
    public bool? HasBorderOutline { get; set; }

    /// <summary>True if the chart data table has vertical cell borders</summary>
    [JsonPropertyName("HasBorderVertical")]
    public bool? HasBorderVertical { get; set; }

    /// <summary>True if the data label legend key is visible.</summary>
    [JsonPropertyName("ShowLegendKey")]
    public bool? ShowLegendKey { get; set; }

}
