using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents tile picture as texture.</summary>
public class TilePicOption
{
    /// <summary>Gets or sets the X offset for tiling picture.</summary>
    [JsonPropertyName("OffsetX")]
    public double? OffsetX { get; set; }

    /// <summary>Gets or sets the Y offset for tiling picture.</summary>
    [JsonPropertyName("OffsetY")]
    public double? OffsetY { get; set; }

    /// <summary>Gets or sets the X scale for tiling picture.</summary>
    [JsonPropertyName("ScaleX")]
    public double? ScaleX { get; set; }

    /// <summary>Gets or sets the Y scale for tiling picture.</summary>
    [JsonPropertyName("ScaleY")]
    public double? ScaleY { get; set; }

    /// <summary>Gets or sets the alignment for tiling.</summary>
    [JsonPropertyName("AlignmentType")]
    public string? AlignmentType { get; set; }

    /// <summary>Gets or sets the mirror type for tiling.</summary>
    [JsonPropertyName("MirrorType")]
    public string? MirrorType { get; set; }

}
