using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents all types of color.</summary>
public class CellsColor
{
    /// <summary>Gets and sets the RGB color.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>Gets and sets the color index in the color palette. Only applies of indexed color.</summary>
    [JsonPropertyName("ColorIndex")]
    public int? ColorIndex { get; set; }

    /// <summary>Gets and set the color which should apply to cell or shape.</summary>
    [JsonPropertyName("IsShapeColor")]
    public bool? IsShapeColor { get; set; }

    /// <summary>Set the tint of the shape color</summary>
    [JsonPropertyName("tint")]
    public double? Tint { get; set; }

    /// <summary>Gets and sets the color from a 32-bit ARGB value.</summary>
    [JsonPropertyName("Argb")]
    public int? Argb { get; set; }

    /// <summary>Gets the theme color. Only applies for theme color type.</summary>
    [JsonPropertyName("ThemeColor")]
    public ThemeColor? ThemeColor { get; set; }

    /// <summary>The color type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets and sets transparency as a value from 0.0 (opaque) through 1.0 (clear).</summary>
    [JsonPropertyName("Transparency")]
    public double? Transparency { get; set; }

}
