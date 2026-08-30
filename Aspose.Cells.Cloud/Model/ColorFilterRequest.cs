using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates color filter request</summary>
public class ColorFilterRequest
{
    /// <summary>Gets or sets the fill pattern type</summary>
    [JsonPropertyName("Pattern")]
    public string? Pattern { get; set; }

    /// <summary>Gets or sets the ForegroundColor.</summary>
    [JsonPropertyName("ForegroundColor")]
    public CellsColor? ForegroundColor { get; set; }

    /// <summary>Gets or sets the BackgroundColor.</summary>
    [JsonPropertyName("BackgroundColor")]
    public CellsColor? BackgroundColor { get; set; }

}
