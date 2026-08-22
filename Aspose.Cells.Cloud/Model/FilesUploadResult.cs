using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>File upload result</summary>
public class FilesUploadResult
{
    /// <summary>List of uploaded file names</summary>
    [JsonPropertyName("Uploaded")]
    public List<string>? Uploaded { get; set; }

    /// <summary>List of errors.</summary>
    [JsonPropertyName("Errors")]
    public List<Error>? Errors { get; set; }

}
