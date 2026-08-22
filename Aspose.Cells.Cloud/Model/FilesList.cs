using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Files list</summary>
public class FilesList
{
    /// <summary>Files and folders contained by folder StorageFile.</summary>
    [JsonPropertyName("Value")]
    public List<StorageFile>? Value { get; set; }

}
