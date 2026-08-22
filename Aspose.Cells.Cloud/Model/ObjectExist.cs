using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Object exists</summary>
public class ObjectExist
{
    /// <summary>Indicates that the file or folder exists.</summary>
    [JsonPropertyName("Exists")]
    public bool? Exists { get; set; }

    /// <summary>True if it is a folder, false if it is a file.</summary>
    [JsonPropertyName("IsFolder")]
    public bool? IsFolder { get; set; }

}
