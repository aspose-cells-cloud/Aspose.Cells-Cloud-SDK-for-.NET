using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ConvertWorksheetOptions model.</summary>
public class ConvertWorksheetOptions : BaseOperateOptions
{
    /// <summary>Gets or sets the DataSource.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Gets or sets the FileInfo.</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the WorksheetName.</summary>
    [JsonPropertyName("WorksheetName")]
    public string? WorksheetName { get; set; }

    /// <summary>Gets or sets the PageSetup.</summary>
    [JsonPropertyName("PageSetup")]
    public PageSetup? PageSetup { get; set; }

    /// <summary>Gets or sets the ImageOrPrintOptions.</summary>
    [JsonPropertyName("ImageOrPrintOptions")]
    public ImageOrPrintOptions? ImageOrPrintOptions { get; set; }

    /// <summary>Gets or sets the ConvertFormat.</summary>
    [JsonPropertyName("ConvertFormat")]
    public string? ConvertFormat { get; set; }

    /// <summary>Gets or sets the CheckExcelRestriction.</summary>
    [JsonPropertyName("CheckExcelRestriction")]
    public bool? CheckExcelRestriction { get; set; }

    /// <summary>Gets or sets the Region.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

}
