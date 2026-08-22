using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents icon filter.</summary>
public class IconFilter
{
    /// <summary>Gets and sets Zero-based index of an icon in an icon set.</summary>
    [JsonPropertyName("IconId")]
    public int? IconId { get; set; }

    /// <summary>Gets and sets which icon set is used in the filter criteria.</summary>
    [JsonPropertyName("IconSetType")]
    public string? IconSetType { get; set; }

}
