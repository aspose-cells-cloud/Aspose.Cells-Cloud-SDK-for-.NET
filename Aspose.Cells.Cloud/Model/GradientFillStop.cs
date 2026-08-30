using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the GradientFillStop model.</summary>
public class GradientFillStop
{
    /// <summary>Color property of type DTO.Color that has a getter and a setter.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

    /// <summary>Gets or sets the Position.</summary>
    [JsonPropertyName("Position")]
    public double? Position { get; set; }

    /// <summary>Gets or sets the Transparency.</summary>
    [JsonPropertyName("Transparency")]
    public double? Transparency { get; set; }

}
