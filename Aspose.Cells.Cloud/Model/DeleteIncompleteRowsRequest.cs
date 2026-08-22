using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm here to help! Could you please provide the features you would like me to summarize?</summary>
public class DeleteIncompleteRowsRequest
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

    /// <summary>A property named "Ranges" of type IList of Range, with a default value of an empty List of Range.</summary>
    [JsonPropertyName("Ranges")]
    public List<Range>? Ranges { get; set; }

}
