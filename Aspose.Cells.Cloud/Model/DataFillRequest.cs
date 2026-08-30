using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the DataFillRequest model.</summary>
public class DataFillRequest
{
    /// <summary>Spreadsheet files that require data fulling.</summary>
    [JsonPropertyName("File")]
    public FileInfo? File { get; set; }

    /// <summary>finish to data cleansing, outfile`s file format.</summary>
    [JsonPropertyName("OutFileFormat")]
    public string? OutFileFormat { get; set; }

    /// <summary>Whether check restriction of Spreadsheet file when user modify cells related objects.</summary>
    [JsonPropertyName("CheckExcelRestriction")]
    public bool? CheckExcelRestriction { get; set; }

    /// <summary>The regional settings for workbook.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

    /// <summary>Fill data default value.</summary>
    [JsonPropertyName("DataFill")]
    public DataFill? DataFill { get; set; }

}
