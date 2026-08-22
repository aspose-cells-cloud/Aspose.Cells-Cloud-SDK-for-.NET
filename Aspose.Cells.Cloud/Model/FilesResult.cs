using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Class features: Weekly lectures, group projects, midterm and final exams, and participation in class discussions.</summary>
public class FilesResult
{
    /// <summary>A property named **Files** of type **IList FileInfo ** containing a collection of file information objects.</summary>
    [JsonPropertyName("Files")]
    public List<FileInfo>? Files { get; set; }

}
