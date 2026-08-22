using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents the cell border.</summary>
public class Border
{
    /// <summary>Gets or sets the cell border type.</summary>
    [JsonPropertyName("LineStyle")]
    public string? LineStyle { get; set; }

    /// <summary>Gets or sets the  of the border.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>This class has a property called "BorderType" of type string that can be both get and set.</summary>
    [JsonPropertyName("BorderType")]
    public string? BorderType { get; set; }

    /// <summary>Gets and sets the theme color of the border.</summary>
    [JsonPropertyName("ThemeColor")]
    public ThemeColor? ThemeColor { get; set; }

    /// <summary>Gets and sets the color with a 32-bit ARGB value.</summary>
    [JsonPropertyName("ArgbColor")]
    public int? ArgbColor { get; set; }

}
