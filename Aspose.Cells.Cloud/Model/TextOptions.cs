using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the text options.</summary>
public class TextOptions : Font
{
    /// <summary>Represents fill format.</summary>
    [JsonPropertyName("Fill")]
    public FillFormat? Fill { get; set; }

    /// <summary>Gets or sets the Kerning.</summary>
    [JsonPropertyName("Kerning")]
    public double? Kerning { get; set; }

    /// <summary>Represents outline format.</summary>
    [JsonPropertyName("Outline")]
    public LineFormat? Outline { get; set; }

    /// <summary>Represents shadow effect.</summary>
    [JsonPropertyName("Shadow")]
    public ShadowEffect? Shadow { get; set; }

    /// <summary>Gets or sets the Spacing.</summary>
    [JsonPropertyName("Spacing")]
    public double? Spacing { get; set; }

    /// <summary>Represents under line color.</summary>
    [JsonPropertyName("UnderlineColor")]
    public CellsColor? UnderlineColor { get; set; }

}
