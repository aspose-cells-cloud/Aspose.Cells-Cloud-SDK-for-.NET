using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>This class specifies the shadow effect of the chart element or shape.</summary>
public class ShadowEffect
{
    /// <summary>Gets and sets the lighting angle. Range from 0 to 359.9 degrees.</summary>
    [JsonPropertyName("Angle")]
    public double? Angle { get; set; }

    /// <summary>Gets and sets the blur of the shadow. Range from 0 to 100 points.</summary>
    [JsonPropertyName("Blur")]
    public double? Blur { get; set; }

    /// <summary>Gets and sets the color of the shadow.</summary>
    [JsonPropertyName("Color")]
    public CellsColor? Color { get; set; }

    /// <summary>Gets and sets the distance of the shadow. Range from 0 to 200 points.</summary>
    [JsonPropertyName("Distance")]
    public double? Distance { get; set; }

    /// <summary>Gets and sets the preset shadow type of the shadow.</summary>
    [JsonPropertyName("PresetType")]
    public string? PresetType { get; set; }

    /// <summary>Gets and sets the size of the shadow. Range from 0 to 2.0.</summary>
    [JsonPropertyName("Size")]
    public double? Size { get; set; }

    /// <summary>Gets and sets the degree of transparency of the shadow. Range from 0.0 (opaque) to 1.0 (clear).</summary>
    [JsonPropertyName("Transparency")]
    public double? Transparency { get; set; }

}
