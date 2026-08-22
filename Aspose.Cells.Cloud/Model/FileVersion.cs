using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the FileVersion model.</summary>
public class FileVersion : StorageFile
{
    /// <summary>Gets or sets the VersionId.</summary>
    [JsonPropertyName("VersionId")]
    public string? VersionId { get; set; }

    /// <summary>Gets or sets the IsLatest.</summary>
    [JsonPropertyName("IsLatest")]
    public bool? IsLatest { get; set; }

}
