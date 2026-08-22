using System.Text.Json.Serialization;
using System;

namespace Aspose.Cells.Cloud.Model;

/// <summary>File or folder information</summary>
public class StorageFile
{
    /// <summary>File or folder name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>True if it is a folder.</summary>
    [JsonPropertyName("IsFolder")]
    public bool? IsFolder { get; set; }

    /// <summary>File or folder last modified DateTime.</summary>
    [JsonPropertyName("ModifiedDate")]
    public DateTime? ModifiedDate { get; set; }

    /// <summary>File or folder size.</summary>
    [JsonPropertyName("Size")]
    public long? Size { get; set; }

    /// <summary>File or folder path.</summary>
    [JsonPropertyName("Path")]
    public string? Path { get; set; }

}
