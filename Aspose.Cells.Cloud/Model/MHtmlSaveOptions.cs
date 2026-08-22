using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the MHtmlSaveOptions model.</summary>
public class MHtmlSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the ExportPageHeaders.</summary>
    [JsonPropertyName("ExportPageHeaders")]
    public bool? ExportPageHeaders { get; set; }

    /// <summary>Gets or sets the ExportPageFooters.</summary>
    [JsonPropertyName("ExportPageFooters")]
    public bool? ExportPageFooters { get; set; }

    /// <summary>Gets or sets the ExportRowColumnHeadings.</summary>
    [JsonPropertyName("ExportRowColumnHeadings")]
    public bool? ExportRowColumnHeadings { get; set; }

    /// <summary>Gets or sets the ShowAllSheets.</summary>
    [JsonPropertyName("ShowAllSheets")]
    public bool? ShowAllSheets { get; set; }

    /// <summary>Gets or sets the ImageOptions.</summary>
    [JsonPropertyName("ImageOptions")]
    public ImageOrPrintOptions? ImageOptions { get; set; }

    /// <summary>Gets or sets the SaveAsSingleFile.</summary>
    [JsonPropertyName("SaveAsSingleFile")]
    public bool? SaveAsSingleFile { get; set; }

    /// <summary>Gets or sets the ExportHiddenWorksheet.</summary>
    [JsonPropertyName("ExportHiddenWorksheet")]
    public bool? ExportHiddenWorksheet { get; set; }

    /// <summary>Gets or sets the ExportGridLines.</summary>
    [JsonPropertyName("ExportGridLines")]
    public bool? ExportGridLines { get; set; }

    /// <summary>Gets or sets the PresentationPreference.</summary>
    [JsonPropertyName("PresentationPreference")]
    public bool? PresentationPreference { get; set; }

    /// <summary>Gets or sets the CellCssPrefix.</summary>
    [JsonPropertyName("CellCssPrefix")]
    public string? CellCssPrefix { get; set; }

    /// <summary>Gets or sets the TableCssId.</summary>
    [JsonPropertyName("TableCssId")]
    public string? TableCssId { get; set; }

    /// <summary>Gets or sets the IsFullPathLink.</summary>
    [JsonPropertyName("IsFullPathLink")]
    public bool? IsFullPathLink { get; set; }

    /// <summary>Gets or sets the ExportWorksheetCSSSeparately.</summary>
    [JsonPropertyName("ExportWorksheetCSSSeparately")]
    public bool? ExportWorksheetCSSSeparately { get; set; }

    /// <summary>Gets or sets the ExportSimilarBorderStyle.</summary>
    [JsonPropertyName("ExportSimilarBorderStyle")]
    public bool? ExportSimilarBorderStyle { get; set; }

    /// <summary>Gets or sets the MergeEmptyTdForcely.</summary>
    [JsonPropertyName("MergeEmptyTdForcely")]
    public bool? MergeEmptyTdForcely { get; set; }

    /// <summary>Gets or sets the ExportCellCoordinate.</summary>
    [JsonPropertyName("ExportCellCoordinate")]
    public bool? ExportCellCoordinate { get; set; }

    /// <summary>Gets or sets the ExportExtraHeadings.</summary>
    [JsonPropertyName("ExportExtraHeadings")]
    public bool? ExportExtraHeadings { get; set; }

    /// <summary>Gets or sets the ExportHeadings.</summary>
    [JsonPropertyName("ExportHeadings")]
    public bool? ExportHeadings { get; set; }

    /// <summary>Gets or sets the ExportFormula.</summary>
    [JsonPropertyName("ExportFormula")]
    public bool? ExportFormula { get; set; }

    /// <summary>Gets or sets the AddTooltipText.</summary>
    [JsonPropertyName("AddTooltipText")]
    public bool? AddTooltipText { get; set; }

    /// <summary>Gets or sets the ExportBogusRowData.</summary>
    [JsonPropertyName("ExportBogusRowData")]
    public bool? ExportBogusRowData { get; set; }

    /// <summary>Gets or sets the ExcludeUnusedStyles.</summary>
    [JsonPropertyName("ExcludeUnusedStyles")]
    public bool? ExcludeUnusedStyles { get; set; }

    /// <summary>Gets or sets the ExportDocumentProperties.</summary>
    [JsonPropertyName("ExportDocumentProperties")]
    public bool? ExportDocumentProperties { get; set; }

    /// <summary>Gets or sets the ExportWorksheetProperties.</summary>
    [JsonPropertyName("ExportWorksheetProperties")]
    public bool? ExportWorksheetProperties { get; set; }

    /// <summary>Gets or sets the ExportWorkbookProperties.</summary>
    [JsonPropertyName("ExportWorkbookProperties")]
    public bool? ExportWorkbookProperties { get; set; }

    /// <summary>Gets or sets the ExportFrameScriptsAndProperties.</summary>
    [JsonPropertyName("ExportFrameScriptsAndProperties")]
    public bool? ExportFrameScriptsAndProperties { get; set; }

    /// <summary>Gets or sets the AttachedFilesDirectory.</summary>
    [JsonPropertyName("AttachedFilesDirectory")]
    public string? AttachedFilesDirectory { get; set; }

    /// <summary>Gets or sets the AttachedFilesUrlPrefix.</summary>
    [JsonPropertyName("AttachedFilesUrlPrefix")]
    public string? AttachedFilesUrlPrefix { get; set; }

    /// <summary>Gets or sets the Encoding.</summary>
    [JsonPropertyName("Encoding")]
    public string? Encoding { get; set; }

    /// <summary>Gets or sets the ExportActiveWorksheetOnly.</summary>
    [JsonPropertyName("ExportActiveWorksheetOnly")]
    public bool? ExportActiveWorksheetOnly { get; set; }

    /// <summary>Gets or sets the ExportChartImageFormat.</summary>
    [JsonPropertyName("ExportChartImageFormat")]
    public string? ExportChartImageFormat { get; set; }

    /// <summary>Gets or sets the ExportImagesAsBase64.</summary>
    [JsonPropertyName("ExportImagesAsBase64")]
    public bool? ExportImagesAsBase64 { get; set; }

    /// <summary>Gets or sets the HiddenColDisplayType.</summary>
    [JsonPropertyName("HiddenColDisplayType")]
    public string? HiddenColDisplayType { get; set; }

    /// <summary>Gets or sets the HiddenRowDisplayType.</summary>
    [JsonPropertyName("HiddenRowDisplayType")]
    public string? HiddenRowDisplayType { get; set; }

    /// <summary>Gets or sets the HtmlCrossStringType.</summary>
    [JsonPropertyName("HtmlCrossStringType")]
    public string? HtmlCrossStringType { get; set; }

    /// <summary>Gets or sets the IsExpImageToTempDir.</summary>
    [JsonPropertyName("IsExpImageToTempDir")]
    public bool? IsExpImageToTempDir { get; set; }

    /// <summary>Gets or sets the PageTitle.</summary>
    [JsonPropertyName("PageTitle")]
    public string? PageTitle { get; set; }

    /// <summary>Gets or sets the ParseHtmlTagInCell.</summary>
    [JsonPropertyName("ParseHtmlTagInCell")]
    public bool? ParseHtmlTagInCell { get; set; }

    /// <summary>Gets or sets the CellNameAttribute.</summary>
    [JsonPropertyName("CellNameAttribute")]
    public string? CellNameAttribute { get; set; }

}
