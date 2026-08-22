using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents the title of chart or axis.</summary>
public class Title : ChartFrame
{
    /// <summary>Represents whether the title is visible.</summary>
    [JsonPropertyName("IsVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>A property named LinkedSource with both set and get accessors is defined.</summary>
    [JsonPropertyName("LinkedSource")]
    public string? LinkedSource { get; set; }

    /// <summary>Gets or sets the RotationAngle.</summary>
    [JsonPropertyName("RotationAngle")]
    public int? RotationAngle { get; set; }

    /// <summary>Gets or sets the text of display unit label.</summary>
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
