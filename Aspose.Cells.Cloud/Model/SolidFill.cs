using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents solid fill format</summary>
public class SolidFill
{
    /// <summary>Gets or sets the .</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>Gets and sets the  object.</summary>
    [JsonPropertyName("CellsColor")]
    public CellsColor? CellsColor { get; set; }

    /// <summary>Returns or sets the degree of transparency of the area as a value from 0.0 (opaque) through 1.0 (clear).</summary>
    [JsonPropertyName("Transparency")]
    public double? Transparency { get; set; }

}
