using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the RenderingWatermark model.</summary>
public class RenderingWatermark
{
    /// <summary>Gets or sets the Rotation.</summary>
    [JsonPropertyName("Rotation")]
    public double? Rotation { get; set; }

    /// <summary>Gets or sets the ScaleToPagePercent.</summary>
    [JsonPropertyName("ScaleToPagePercent")]
    public int? ScaleToPagePercent { get; set; }

    /// <summary>Gets or sets the Opacity.</summary>
    [JsonPropertyName("Opacity")]
    public double? Opacity { get; set; }

    /// <summary>Gets or sets the IsBackground.</summary>
    [JsonPropertyName("IsBackground")]
    public bool? IsBackground { get; set; }

    /// <summary>Gets or sets the Text.</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

    /// <summary>Gets or sets the Font.</summary>
    [JsonPropertyName("Font")]
    public RenderingFont? Font { get; set; }

    /// <summary>Gets or sets the Image.</summary>
    [JsonPropertyName("Image")]
    public byte[]? Image { get; set; }

    /// <summary>Gets or sets the HAlignment.</summary>
    [JsonPropertyName("HAlignment")]
    public string? HAlignment { get; set; }

    /// <summary>Gets or sets the VAlignment.</summary>
    [JsonPropertyName("VAlignment")]
    public string? VAlignment { get; set; }

    /// <summary>Gets or sets the OffsetX.</summary>
    [JsonPropertyName("OffsetX")]
    public double? OffsetX { get; set; }

    /// <summary>Gets or sets the OffsetY.</summary>
    [JsonPropertyName("OffsetY")]
    public double? OffsetY { get; set; }

}
