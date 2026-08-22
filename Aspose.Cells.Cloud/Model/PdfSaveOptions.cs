using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PdfSaveOptions model.</summary>
public class PdfSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the DisplayDocTitle.</summary>
    [JsonPropertyName("DisplayDocTitle")]
    public bool? DisplayDocTitle { get; set; }

    /// <summary>Gets or sets the ExportDocumentStructure.</summary>
    [JsonPropertyName("ExportDocumentStructure")]
    public bool? ExportDocumentStructure { get; set; }

    /// <summary>Gets or sets the EmfRenderSetting.</summary>
    [JsonPropertyName("EmfRenderSetting")]
    public string? EmfRenderSetting { get; set; }

    /// <summary>Gets or sets the CustomPropertiesExport.</summary>
    [JsonPropertyName("CustomPropertiesExport")]
    public string? CustomPropertiesExport { get; set; }

    /// <summary>Gets or sets the OptimizationType.</summary>
    [JsonPropertyName("OptimizationType")]
    public string? OptimizationType { get; set; }

    /// <summary>Gets or sets the Producer.</summary>
    [JsonPropertyName("Producer")]
    public string? Producer { get; set; }

    /// <summary>Gets or sets the PdfCompression.</summary>
    [JsonPropertyName("PdfCompression")]
    public string? PdfCompression { get; set; }

    /// <summary>Gets or sets the FontEncoding.</summary>
    [JsonPropertyName("FontEncoding")]
    public string? FontEncoding { get; set; }

    /// <summary>Gets or sets the Watermark.</summary>
    [JsonPropertyName("Watermark")]
    public RenderingWatermark? Watermark { get; set; }

    /// <summary>Gets or sets the CalculateFormula.</summary>
    [JsonPropertyName("CalculateFormula")]
    public bool? CalculateFormula { get; set; }

    /// <summary>Gets or sets the CheckFontCompatibility.</summary>
    [JsonPropertyName("CheckFontCompatibility")]
    public bool? CheckFontCompatibility { get; set; }

    /// <summary>Gets or sets the Compliance.</summary>
    [JsonPropertyName("Compliance")]
    public string? Compliance { get; set; }

    /// <summary>Gets or sets the DefaultFont.</summary>
    [JsonPropertyName("DefaultFont")]
    public string? DefaultFont { get; set; }

    /// <summary>Gets or sets the OnePagePerSheet.</summary>
    [JsonPropertyName("OnePagePerSheet")]
    public bool? OnePagePerSheet { get; set; }

    /// <summary>Gets or sets the PrintingPageType.</summary>
    [JsonPropertyName("PrintingPageType")]
    public string? PrintingPageType { get; set; }

    /// <summary>Gets or sets the SecurityOptions.</summary>
    [JsonPropertyName("SecurityOptions")]
    public PdfSecurityOptions? SecurityOptions { get; set; }

    /// <summary>Gets or sets the desiredPPI.</summary>
    [JsonPropertyName("desiredPPI")]
    public int? DesiredPPI { get; set; }

    /// <summary>Gets or sets the jpegQuality.</summary>
    [JsonPropertyName("jpegQuality")]
    public int? JpegQuality { get; set; }

    /// <summary>Gets or sets the ImageType.</summary>
    [JsonPropertyName("ImageType")]
    public string? ImageType { get; set; }

}
