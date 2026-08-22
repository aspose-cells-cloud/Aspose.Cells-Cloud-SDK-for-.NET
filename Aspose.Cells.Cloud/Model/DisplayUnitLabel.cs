using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the display unit label.</summary>
public class DisplayUnitLabel : ChartFrame
{
    /// <summary>A public property named "LinkedSource" with a string data type can be set and accessed.</summary>
    [JsonPropertyName("LinkedSource")]
    public string? LinkedSource { get; set; }

    /// <summary>Gets or sets the RotationAngle.</summary>
    [JsonPropertyName("RotationAngle")]
    public int? RotationAngle { get; set; }

    /// <summary>Gets or sets the text of display unit label.</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

    /// <summary>Gets or sets the TextHorizontalAlignment.</summary>
    [JsonPropertyName("TextHorizontalAlignment")]
    public string? TextHorizontalAlignment { get; set; }

    /// <summary>Gets or sets the TextVerticalAlignment.</summary>
    [JsonPropertyName("TextVerticalAlignment")]
    public string? TextVerticalAlignment { get; set; }

}
