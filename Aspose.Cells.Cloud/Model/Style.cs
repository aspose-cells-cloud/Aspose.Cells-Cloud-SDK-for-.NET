using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents display style of excel document,such as font,color,alignment,border,etc.            The Style object contains all style attributes (font, number format, alignment, and so on) as properties.</summary>
public class Style
{
    /// <summary>Gets a  object.</summary>
    [JsonPropertyName("Font")]
    public Font? Font { get; set; }

    /// <summary>Gets or sets the name of the style.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets and sets the culture-dependent pattern string for number format.</summary>
    [JsonPropertyName("CultureCustom")]
    public string? CultureCustom { get; set; }

    /// <summary>Represents the custom number format string of this style object.</summary>
    [JsonPropertyName("Custom")]
    public string? Custom { get; set; }

    /// <summary>Gets or sets a style's background color.</summary>
    [JsonPropertyName("BackgroundColor")]
    public Color? BackgroundColor { get; set; }

    /// <summary>Gets or sets a style's foreground color.</summary>
    [JsonPropertyName("ForegroundColor")]
    public Color? ForegroundColor { get; set; }

    /// <summary>Represents if the formula will be hidden when the worksheet is protected.</summary>
    [JsonPropertyName("IsFormulaHidden")]
    public bool? IsFormulaHidden { get; set; }

    /// <summary>Indicates whether the number format is a date format.</summary>
    [JsonPropertyName("IsDateTime")]
    public bool? IsDateTime { get; set; }

    /// <summary>Gets or sets a value indicating whether the text within a cell is wrapped.</summary>
    [JsonPropertyName("IsTextWrapped")]
    public bool? IsTextWrapped { get; set; }

    /// <summary>Indicates whether the cell shading is a gradient pattern.</summary>
    [JsonPropertyName("IsGradient")]
    public bool? IsGradient { get; set; }

    /// <summary>Gets or sets a value indicating whether a cell can be modified or not.</summary>
    [JsonPropertyName("IsLocked")]
    public bool? IsLocked { get; set; }

    /// <summary>Indicates whether the number format is a percent format.</summary>
    [JsonPropertyName("IsPercent")]
    public bool? IsPercent { get; set; }

    /// <summary>Represents if text automatically shrinks to fit in the available column width.</summary>
    [JsonPropertyName("ShrinkToFit")]
    public bool? ShrinkToFit { get; set; }

    /// <summary>Represents the indent level for the cell or range. Can only be an integer from 0 to 250.</summary>
    [JsonPropertyName("IndentLevel")]
    public int? IndentLevel { get; set; }

    /// <summary>Gets or sets the display format of numbers and dates. The formatting patterns are different for different regions.</summary>
    [JsonPropertyName("Number")]
    public int? Number { get; set; }

    /// <summary>Represents text rotation angle.</summary>
    [JsonPropertyName("RotationAngle")]
    public int? RotationAngle { get; set; }

    /// <summary>Gets or sets the cell background pattern type.</summary>
    [JsonPropertyName("Pattern")]
    public string? Pattern { get; set; }

    /// <summary>Represents text reading order.</summary>
    [JsonPropertyName("TextDirection")]
    public string? TextDirection { get; set; }

    /// <summary>Gets or sets the vertical alignment type of the text in a cell.</summary>
    [JsonPropertyName("VerticalAlignment")]
    public string? VerticalAlignment { get; set; }

    /// <summary>Gets or sets the horizontal alignment type of the text in a cell.</summary>
    [JsonPropertyName("HorizontalAlignment")]
    public string? HorizontalAlignment { get; set; }

    /// <summary>A public property named `BorderCollection` that is a list of `Border` objects.</summary>
    [JsonPropertyName("BorderCollection")]
    public List<Border>? BorderCollection { get; set; }

    /// <summary>Gets and sets the background theme color.</summary>
    [JsonPropertyName("BackgroundThemeColor")]
    public ThemeColor? BackgroundThemeColor { get; set; }

    /// <summary>Gets and sets the foreground theme color.</summary>
    [JsonPropertyName("ForegroundThemeColor")]
    public ThemeColor? ForegroundThemeColor { get; set; }

}
