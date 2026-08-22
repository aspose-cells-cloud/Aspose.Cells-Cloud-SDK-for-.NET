using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the XlsbSaveOptions model.</summary>
public class XlsbSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the ExportAllColumnIndexes.</summary>
    [JsonPropertyName("ExportAllColumnIndexes")]
    public bool? ExportAllColumnIndexes { get; set; }

    /// <summary>Gets or sets the CompressionType.</summary>
    [JsonPropertyName("CompressionType")]
    public string? CompressionType { get; set; }

}
