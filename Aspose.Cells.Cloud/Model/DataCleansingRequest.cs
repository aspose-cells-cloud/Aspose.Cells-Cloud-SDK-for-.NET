using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>A data cleansing request for an Spreadsheet file.</summary>
public class DataCleansingRequest
{
    /// <summary>Spreadsheet files that require data cleaning.</summary>
    [JsonPropertyName("File")]
    public FileInfo? File { get; set; }

    /// <summary>Whether check restriction of Spreadsheet file when user modify cells related objects.</summary>
    [JsonPropertyName("CheckExcelRestriction")]
    public bool? CheckExcelRestriction { get; set; }

    /// <summary>The regional settings for workbook.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

    /// <summary>finish to data cleansing, outfile`s file format.</summary>
    [JsonPropertyName("OutFileFormat")]
    public string? OutFileFormat { get; set; }

    /// <summary>Data cleansing content</summary>
    [JsonPropertyName("DataCleansing")]
    public DataCleansing? DataCleansing { get; set; }

}
