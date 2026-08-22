using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm happy to help! Could you please provide me with the features you would like me to summarize for you?</summary>
public class ExtractTextOptions : BaseOperateOptions
{
    /// <summary>Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents file information. Include of filename, filesize, and file content(base64String).</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the Worksheet.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

    /// <summary>Gets or sets the Range.</summary>
    [JsonPropertyName("Range")]
    public string? Range { get; set; }

    /// <summary>Gets or sets the ExtractTextType.</summary>
    [JsonPropertyName("ExtractTextType")]
    public string? ExtractTextType { get; set; }

    /// <summary>Gets or sets the BeforeText.</summary>
    [JsonPropertyName("BeforeText")]
    public string? BeforeText { get; set; }

    /// <summary>Gets or sets the AfterText.</summary>
    [JsonPropertyName("AfterText")]
    public string? AfterText { get; set; }

    /// <summary>Gets or sets the BeforePosition.</summary>
    [JsonPropertyName("BeforePosition")]
    public int? BeforePosition { get; set; }

    /// <summary>Gets or sets the AfterPosition.</summary>
    [JsonPropertyName("AfterPosition")]
    public int? AfterPosition { get; set; }

    /// <summary>Gets or sets the OutPositionRange.</summary>
    [JsonPropertyName("OutPositionRange")]
    public string? OutPositionRange { get; set; }

}
