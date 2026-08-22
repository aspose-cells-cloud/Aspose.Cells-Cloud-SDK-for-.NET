using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Class summary: Understanding the various features and tools available in Adobe Illustrator to create dynamic and professional vector graphics, including shapes, text, brushes, gradients, and layers.</summary>
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
