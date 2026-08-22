using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Class summary: The features of this class include hands-on learning activities, group projects, interactive discussions, guest speakers, and field trips to real-world applications.</summary>
public class AddTextOptions : BaseOperateOptions
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

    /// <summary>Add text content.</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

    /// <summary>Represents where text should be inserted or selected in the spreadsheet.</summary>
    [JsonPropertyName("SelectPoistion")]
    public string? SelectPoistion { get; set; }

    /// <summary>Selected text of cell where text should be inserted or selected in the spreadsheet.</summary>
    [JsonPropertyName("SelectText")]
    public string? SelectText { get; set; }

    /// <summary>Indicates whether empty cells should be skipped during processing.</summary>
    [JsonPropertyName("SkipEmptyCells")]
    public bool? SkipEmptyCells { get; set; }

}
