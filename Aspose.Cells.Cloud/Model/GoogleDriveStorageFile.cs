using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the GoogleDriveStorageFile model.</summary>
public class GoogleDriveStorageFile : StorageFile
{
    /// <summary>Gets or sets the MimeType.</summary>
    [JsonPropertyName("MimeType")]
    public string? MimeType { get; set; }

}
