using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents texture fill format</summary>
public class TextureFill
{
    /// <summary>Gets and sets the texture type</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Returns or sets the degree of transparency of the area as a value from 0.0 (opaque) through 1.0 (clear).</summary>
    [JsonPropertyName("Transparency")]
    public double? Transparency { get; set; }

    /// <summary>Gets and sets the picture format scale.</summary>
    [JsonPropertyName("Scale")]
    public double? Scale { get; set; }

    /// <summary>Gets or sets tile picture option.</summary>
    [JsonPropertyName("TilePicOption")]
    public TilePicOption? TilePicOption { get; set; }

    /// <summary>Gets or sets picture format option.</summary>
    [JsonPropertyName("PicFormatOption")]
    public PicFormatOption? PicFormatOption { get; set; }

    /// <summary>The class has a public property named "Image" of type LinkElement that can be accessed and set.</summary>
    [JsonPropertyName("Image")]
    public LinkElement? Image { get; set; }

}
