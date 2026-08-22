using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Class summary: The features of the new smartphone include a high-resolution display, multiple camera lenses for versatile photography, a fast processor for seamless performance, and a larger battery for extended usage time.</summary>
public class ConvertTextOptions : BaseOperateOptions
{
    /// <summary>Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents file information. Include of filename, filesize, and file content(base64String).</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Specifies the range of cells within the worksheet where the spreadsheet operations will be performed. This parameter allows users to define the exact area to be processed, ensuring that operations are applied only to the designated cells.</summary>
    [JsonPropertyName("ScopeOptions")]
    public ScopeOptions? ScopeOptions { get; set; }

    /// <summary>Gets or sets the ConvertTextType.</summary>
    [JsonPropertyName("ConvertTextType")]
    public string? ConvertTextType { get; set; }

    /// <summary>Gets or sets the SourceCharacters.</summary>
    [JsonPropertyName("SourceCharacters")]
    public string? SourceCharacters { get; set; }

    /// <summary>Gets or sets the TargetCharacters.</summary>
    [JsonPropertyName("TargetCharacters")]
    public string? TargetCharacters { get; set; }

}
