using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates text water marker request.</summary>
public class TextWaterMarkerRequest
{
    /// <summary>A property named Text of type string that can be accessed and modified.</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

    /// <summary>Indicates font name.</summary>
    [JsonPropertyName("FontName")]
    public string? FontName { get; set; }

    /// <summary>Indicates font size.</summary>
    [JsonPropertyName("FontSize")]
    public int? FontSize { get; set; }

    /// <summary>Indicates image height.</summary>
    [JsonPropertyName("Height")]
    public int? Height { get; set; }

    /// <summary>Indicates image width.</summary>
    [JsonPropertyName("Width")]
    public int? Width { get; set; }

    /// <summary>Gets or sets the ImageAdaptOption.</summary>
    [JsonPropertyName("ImageAdaptOption")]
    public string? ImageAdaptOption { get; set; }

}
