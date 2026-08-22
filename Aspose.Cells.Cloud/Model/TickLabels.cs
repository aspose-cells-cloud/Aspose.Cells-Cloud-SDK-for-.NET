using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the tick-mark labels associated with tick marks on a chart axis.</summary>
public class TickLabels : LinkElement
{
    /// <summary>True if the text in the object changes font size when the object size changes. The default value is True.</summary>
    [JsonPropertyName("AutoScaleFont")]
    public bool? AutoScaleFont { get; set; }

    /// <summary>Gets and sets the display mode of the background</summary>
    [JsonPropertyName("BackgroundMode")]
    public string? BackgroundMode { get; set; }

    /// <summary>Returns a  object that represents the font of the specified TickLabels object.</summary>
    [JsonPropertyName("Font")]
    public Font? Font { get; set; }

    /// <summary>Represents the format number for the TickLabels object.</summary>
    [JsonPropertyName("Number")]
    public int? Number { get; set; }

    /// <summary>Represents the format string for the TickLabels object.</summary>
    [JsonPropertyName("NumberFormat")]
    public string? NumberFormat { get; set; }

    /// <summary>True if the number format is linked to the cells</summary>
    [JsonPropertyName("NumberFormatLinked")]
    public bool? NumberFormatLinked { get; set; }

    /// <summary>Gets and sets the distance of labels from the axis.</summary>
    [JsonPropertyName("Offset")]
    public int? Offset { get; set; }

    /// <summary>Represents text rotation angle in clockwise.</summary>
    [JsonPropertyName("RotationAngle")]
    public int? RotationAngle { get; set; }

    /// <summary>Represents text reading order.</summary>
    [JsonPropertyName("TextDirection")]
    public string? TextDirection { get; set; }

    /// <summary>Represents text reading order.</summary>
    [JsonPropertyName("ReadingOrder")]
    public string? ReadingOrder { get; set; }

    /// <summary>Gets and sets the direction of text.</summary>
    [JsonPropertyName("DirectionType")]
    public string? DirectionType { get; set; }

}
