using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the FileSource model.</summary>
public class FileSource
{
    /// <summary>A property named FileSourceType of type FileSourceType that can be accessed and modified.</summary>
    [JsonPropertyName("FileSourceType")]
    public string? FileSourceType { get; set; }

    /// <summary>Gets or sets the FilePath.</summary>
    [JsonPropertyName("FilePath")]
    public string? FilePath { get; set; }

}
