using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ColorFilter model.</summary>
public class ColorFilter
{
    /// <summary>Whether filter by the cell's fill color.</summary>
    [JsonPropertyName("FilterByFillColor")]
    public bool? FilterByFillColor { get; set; }

    /// <summary>A property "Pattern" of type string with a getter and setter is defined.</summary>
    [JsonPropertyName("Pattern")]
    public string? Pattern { get; set; }

    /// <summary>Gets or sets the Color.</summary>
    [JsonPropertyName("Color")]
    public CellsColor? Color { get; set; }

    /// <summary>Gets or sets the ForegroundColorColor.</summary>
    [JsonPropertyName("ForegroundColorColor")]
    public CellsColor? ForegroundColorColor { get; set; }

    /// <summary>Gets or sets the BackgroundColor.</summary>
    [JsonPropertyName("BackgroundColor")]
    public CellsColor? BackgroundColor { get; set; }

}
