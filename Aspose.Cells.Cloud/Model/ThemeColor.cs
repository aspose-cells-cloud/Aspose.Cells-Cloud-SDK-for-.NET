using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a theme color.</summary>
public class ThemeColor
{
    /// <summary>Gets and sets the theme type.</summary>
    [JsonPropertyName("ColorType")]
    public string? ColorType { get; set; }

    /// <summary>Gets and sets the tint value.</summary>
    [JsonPropertyName("Tint")]
    public double? Tint { get; set; }

}
