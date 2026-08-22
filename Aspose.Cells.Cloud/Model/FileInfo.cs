using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents file information.</summary>
public class FileInfo
{
    /// <summary>Represents filename.</summary>
    [JsonPropertyName("Filename")]
    public string? Filename { get; set; }

    /// <summary>Represents file size.</summary>
    [JsonPropertyName("FileSize")]
    public long? FileSize { get; set; }

    /// <summary>Represents file content,  byte to base64 string.</summary>
    [JsonPropertyName("FileContent")]
    public string? FileContent { get; set; }

}
