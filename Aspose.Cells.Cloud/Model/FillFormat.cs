using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents fill formatting for a shape.</summary>
public class FillFormat
{
    /// <summary>Gets and sets the fill type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets  object.</summary>
    [JsonPropertyName("SolidFill")]
    public SolidFill? SolidFill { get; set; }

    /// <summary>Gets  object.</summary>
    [JsonPropertyName("PatternFill")]
    public PatternFill? PatternFill { get; set; }

    /// <summary>Gets  object.</summary>
    [JsonPropertyName("TextureFill")]
    public TextureFill? TextureFill { get; set; }

    /// <summary>Gets  object.</summary>
    [JsonPropertyName("GradientFill")]
    public GradientFill? GradientFill { get; set; }

    /// <summary>Gets and sets the picture image data.</summary>
    [JsonPropertyName("ImageData")]
    public string? ImageData { get; set; }

}
