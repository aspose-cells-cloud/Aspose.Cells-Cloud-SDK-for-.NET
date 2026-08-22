using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents pattern fill format</summary>
public class PatternFill
{
    /// <summary>Gets or sets the fill pattern type</summary>
    [JsonPropertyName("Pattern")]
    public string? Pattern { get; set; }

    /// <summary>Gets and sets the foreground  object.</summary>
    [JsonPropertyName("BackgroundCellsColor")]
    public CellsColor? BackgroundCellsColor { get; set; }

    /// <summary>Gets and sets the foreground  object.</summary>
    [JsonPropertyName("ForegroundCellsColor")]
    public CellsColor? ForegroundCellsColor { get; set; }

    /// <summary>Gets or sets the foreground .</summary>
    [JsonPropertyName("ForegroundColor")]
    public Color? ForegroundColor { get; set; }

    /// <summary>Gets or sets the background  of the .</summary>
    [JsonPropertyName("BackgroundColor")]
    public Color? BackgroundColor { get; set; }

    /// <summary>Gets or sets the transparency of background color.</summary>
    [JsonPropertyName("BackTransparency")]
    public double? BackTransparency { get; set; }

    /// <summary>Gets or sets the transparency of foreground color.</summary>
    [JsonPropertyName("ForeTransparency")]
    public double? ForeTransparency { get; set; }

}
