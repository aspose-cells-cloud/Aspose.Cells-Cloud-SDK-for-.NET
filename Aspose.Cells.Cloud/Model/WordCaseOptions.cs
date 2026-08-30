using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the WordCaseOptions model.</summary>
public class WordCaseOptions
{
    /// <summary>Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents file information. Include of filename, filesize, and file content(base64String).</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the WordCaseType.</summary>
    [JsonPropertyName("WordCaseType")]
    public string? WordCaseType { get; set; }

    /// <summary>Gets or sets the ScopeOptions.</summary>
    [JsonPropertyName("ScopeOptions")]
    public ScopeOptions? ScopeOptions { get; set; }

}
