using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the color settings of the data bars for negative values that are</summary>
public class NegativeBarFormat
{
    /// <summary>Gets or sets a FormatColor object that you can use to specify the border color for negative data bars.</summary>
    [JsonPropertyName("BorderColor")]
    public Color? BorderColor { get; set; }

    /// <summary>Gets whether to use the same border color as positive data bars.</summary>
    [JsonPropertyName("BorderColorType")]
    public string? BorderColorType { get; set; }

    /// <summary>Gets or sets a FormatColor object that you can use to specify the fill color for negative data bars.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>Gets or sets whether to use the same fill color as positive data bars.</summary>
    [JsonPropertyName("ColorType")]
    public string? ColorType { get; set; }

}
