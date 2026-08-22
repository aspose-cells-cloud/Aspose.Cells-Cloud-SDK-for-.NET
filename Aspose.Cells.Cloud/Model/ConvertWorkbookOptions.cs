using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ConvertWorkbookOptions model.</summary>
public class ConvertWorkbookOptions : BaseOperateOptions
{
    /// <summary>Gets or sets the DataSource.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Gets or sets the FileInfo.</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the PageSetup.</summary>
    [JsonPropertyName("PageSetup")]
    public PageSetup? PageSetup { get; set; }

    /// <summary>Gets or sets the SaveOptions.</summary>
    [JsonPropertyName("SaveOptions")]
    public SaveOptions? SaveOptions { get; set; }

    /// <summary>Gets or sets the ConvertFormat.</summary>
    [JsonPropertyName("ConvertFormat")]
    public string? ConvertFormat { get; set; }

    /// <summary>Gets or sets the CheckExcelRestriction.</summary>
    [JsonPropertyName("CheckExcelRestriction")]
    public bool? CheckExcelRestriction { get; set; }

}
