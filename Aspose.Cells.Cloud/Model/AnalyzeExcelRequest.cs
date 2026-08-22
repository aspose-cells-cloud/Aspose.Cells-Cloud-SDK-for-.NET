using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Can you please provide the features that you would like me to summarize for the class?</summary>
public class AnalyzeExcelRequest
{
    /// <summary>The class has a property called "Files" that is a list of FileInfo objects with a default value of an empty list.</summary>
    [JsonPropertyName("Files")]
    public List<FileInfo>? Files { get; set; }

    /// <summary>Gets or sets the NeedThumbnail.</summary>
    [JsonPropertyName("NeedThumbnail")]
    public bool? NeedThumbnail { get; set; }

    /// <summary>Gets or sets the BuildSuggestoinSheet.</summary>
    [JsonPropertyName("BuildSuggestoinSheet")]
    public bool? BuildSuggestoinSheet { get; set; }

}
