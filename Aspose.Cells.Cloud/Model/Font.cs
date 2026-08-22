using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the font object used in a spreadsheet.</summary>
public class Font
{
    /// <summary>Gets or sets the  of the font.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>Gets and sets the double size of the font.</summary>
    [JsonPropertyName("DoubleSize")]
    public double? DoubleSize { get; set; }

    /// <summary>Gets or sets a value indicating whether the font is bold.</summary>
    [JsonPropertyName("IsBold")]
    public bool? IsBold { get; set; }

    /// <summary>Gets or sets a value indicating whether the font is italic.</summary>
    [JsonPropertyName("IsItalic")]
    public bool? IsItalic { get; set; }

    /// <summary>Gets or sets a value indicating whether the font is single strikeout.</summary>
    [JsonPropertyName("IsStrikeout")]
    public bool? IsStrikeout { get; set; }

    /// <summary>Gets or sets a value indicating whether the font is subscript.</summary>
    [JsonPropertyName("IsSubscript")]
    public bool? IsSubscript { get; set; }

    /// <summary>Gets or sets a value indicating whether the font is super script.</summary>
    [JsonPropertyName("IsSuperscript")]
    public bool? IsSuperscript { get; set; }

    /// <summary>Gets  or sets the name of the .</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the size of the font.</summary>
    [JsonPropertyName("Size")]
    public int? Size { get; set; }

    /// <summary>Gets or sets the font underline type.</summary>
    [JsonPropertyName("Underline")]
    public string? Underline { get; set; }

}
