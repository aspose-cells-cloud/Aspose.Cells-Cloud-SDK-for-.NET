using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the OoxmlSaveOptions model.</summary>
public class OoxmlSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the ExportCellName.</summary>
    [JsonPropertyName("ExportCellName")]
    public bool? ExportCellName { get; set; }

    /// <summary>Gets or sets the UpdateZoom.</summary>
    [JsonPropertyName("UpdateZoom")]
    public bool? UpdateZoom { get; set; }

    /// <summary>Gets or sets the EnableZip64.</summary>
    [JsonPropertyName("EnableZip64")]
    public bool? EnableZip64 { get; set; }

    /// <summary>Gets or sets the EmbedOoxmlAsOleObject.</summary>
    [JsonPropertyName("EmbedOoxmlAsOleObject")]
    public bool? EmbedOoxmlAsOleObject { get; set; }

    /// <summary>Gets or sets the CompressionType.</summary>
    [JsonPropertyName("CompressionType")]
    public string? CompressionType { get; set; }

}
