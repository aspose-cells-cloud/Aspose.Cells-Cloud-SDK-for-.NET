using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the RenderingFont model.</summary>
public class RenderingFont
{
    /// <summary>Gets or sets the Name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the Size.</summary>
    [JsonPropertyName("Size")]
    public double? Size { get; set; }

    /// <summary>Gets or sets the Bold.</summary>
    [JsonPropertyName("Bold")]
    public bool? Bold { get; set; }

    /// <summary>Gets or sets the Italic.</summary>
    [JsonPropertyName("Italic")]
    public bool? Italic { get; set; }

    /// <summary>Gets or sets the Color.</summary>
    [JsonPropertyName("Color")]
    public Color? Color { get; set; }

}
