using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the TrimContentOptions model.</summary>
public class TrimContentOptions
{
    /// <summary>Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents file information. Include of filename, filesize, and file content(base64String).</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the TrimContent.</summary>
    [JsonPropertyName("TrimContent")]
    public string? TrimContent { get; set; }

    /// <summary>If the trim leading value is true, the trim content before and after cell values will be deleted.</summary>
    [JsonPropertyName("TrimLeading")]
    public bool? TrimLeading { get; set; }

    /// <summary>If the trim trailing value is true, the trim content before and after cell values will be deleted.</summary>
    [JsonPropertyName("TrimTrailing")]
    public bool? TrimTrailing { get; set; }

    /// <summary>When the trim space between word to 1 parameter is true, it enables the removal of extra spaces between words within a cell, ensuring that only a single space is maintained between words.</summary>
    [JsonPropertyName("TrimSpaceBetweenWordTo1")]
    public bool? TrimSpaceBetweenWordTo1 { get; set; }

    /// <summary>Gets or sets the TrimNonBreakingSpaces.</summary>
    [JsonPropertyName("TrimNonBreakingSpaces")]
    public bool? TrimNonBreakingSpaces { get; set; }

    /// <summary>When this parameter is enabled (set to True), it deletes extra line breaks within the selected range, ensuring that only necessary line breaks are retained.</summary>
    [JsonPropertyName("RemoveExtraLineBreaks")]
    public bool? RemoveExtraLineBreaks { get; set; }

    /// <summary>When this parameter is enabled (set to True), it removes all line breaks within the selected range, resulting in a continuous block of text without any line breaks.</summary>
    [JsonPropertyName("RemoveAllLineBreaks")]
    public bool? RemoveAllLineBreaks { get; set; }

    /// <summary>Specifies the range of cells within the worksheet where the spreadsheet operations will be performed. This parameter allows users to define the exact area to be processed, ensuring that operations are applied only to the designated cells.</summary>
    [JsonPropertyName("ScopeOptions")]
    public ScopeOptions? ScopeOptions { get; set; }

}
