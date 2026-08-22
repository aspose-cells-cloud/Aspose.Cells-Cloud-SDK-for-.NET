using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the DataDeduplicationRequest model.</summary>
public class DataDeduplicationRequest
{
    /// <summary>Spreadsheet files that require data fulling.</summary>
    [JsonPropertyName("File")]
    public FileInfo? File { get; set; }

    /// <summary>This class has a property named "DeduplicationRegion" of type "DeduplicationRegion" with a default value of a new instance of the "DeduplicationRegion" class.</summary>
    [JsonPropertyName("DeduplicationRegion")]
    public DeduplicationRegion? DeduplicationRegion { get; set; }

    /// <summary>finish to data cleansing, outfile`s file format.</summary>
    [JsonPropertyName("OutFileFormat")]
    public string? OutFileFormat { get; set; }

    /// <summary>Whether check restriction of Spreadsheet file when user modify cells related objects.</summary>
    [JsonPropertyName("CheckExcelRestriction")]
    public bool? CheckExcelRestriction { get; set; }

    /// <summary>The regional settings for workbook.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

}
