using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ImageOrPrintOptions model.</summary>
public class ImageOrPrintOptions
{
    /// <summary>Gets or sets the TextCrossType.</summary>
    [JsonPropertyName("TextCrossType")]
    public string? TextCrossType { get; set; }

    /// <summary>Gets or sets the GridlineType.</summary>
    [JsonPropertyName("GridlineType")]
    public string? GridlineType { get; set; }

    /// <summary>Gets or sets the OutputBlankPageWhenNothingToPrint.</summary>
    [JsonPropertyName("OutputBlankPageWhenNothingToPrint")]
    public bool? OutputBlankPageWhenNothingToPrint { get; set; }

    /// <summary>Gets or sets the CheckWorkbookDefaultFont.</summary>
    [JsonPropertyName("CheckWorkbookDefaultFont")]
    public bool? CheckWorkbookDefaultFont { get; set; }

    /// <summary>Gets or sets the DefaultFont.</summary>
    [JsonPropertyName("DefaultFont")]
    public string? DefaultFont { get; set; }

    /// <summary>Gets or sets the IsOptimized.</summary>
    [JsonPropertyName("IsOptimized")]
    public bool? IsOptimized { get; set; }

    /// <summary>Gets or sets the PageCount.</summary>
    [JsonPropertyName("PageCount")]
    public int? PageCount { get; set; }

    /// <summary>Gets or sets the PageIndex.</summary>
    [JsonPropertyName("PageIndex")]
    public int? PageIndex { get; set; }

    /// <summary>Gets or sets the IsFontSubstitutionCharGranularity.</summary>
    [JsonPropertyName("IsFontSubstitutionCharGranularity")]
    public bool? IsFontSubstitutionCharGranularity { get; set; }

    /// <summary>Gets or sets the Transparent.</summary>
    [JsonPropertyName("Transparent")]
    public bool? Transparent { get; set; }

    /// <summary>Gets or sets the OnlyArea.</summary>
    [JsonPropertyName("OnlyArea")]
    public bool? OnlyArea { get; set; }

    /// <summary>Gets or sets the SVGFitToViewPort.</summary>
    [JsonPropertyName("SVGFitToViewPort")]
    public bool? SVGFitToViewPort { get; set; }

    /// <summary>Gets or sets the EmbededImageNameInSvg.</summary>
    [JsonPropertyName("EmbededImageNameInSvg")]
    public string? EmbededImageNameInSvg { get; set; }

    /// <summary>Gets or sets the AllColumnsInOnePagePerSheet.</summary>
    [JsonPropertyName("AllColumnsInOnePagePerSheet")]
    public bool? AllColumnsInOnePagePerSheet { get; set; }

    /// <summary>Gets or sets the PrintWithStatusDialog.</summary>
    [JsonPropertyName("PrintWithStatusDialog")]
    public bool? PrintWithStatusDialog { get; set; }

    /// <summary>Gets or sets the HorizontalResolution.</summary>
    [JsonPropertyName("HorizontalResolution")]
    public int? HorizontalResolution { get; set; }

    /// <summary>Gets or sets the VerticalResolution.</summary>
    [JsonPropertyName("VerticalResolution")]
    public int? VerticalResolution { get; set; }

    /// <summary>Gets or sets the DefaultEditLanguage.</summary>
    [JsonPropertyName("DefaultEditLanguage")]
    public string? DefaultEditLanguage { get; set; }

    /// <summary>Gets or sets the TiffColorDepth.</summary>
    [JsonPropertyName("TiffColorDepth")]
    public string? TiffColorDepth { get; set; }

    /// <summary>Gets or sets the TiffCompression.</summary>
    [JsonPropertyName("TiffCompression")]
    public string? TiffCompression { get; set; }

    /// <summary>Gets or sets the PrintingPage.</summary>
    [JsonPropertyName("PrintingPage")]
    public string? PrintingPage { get; set; }

    /// <summary>Gets or sets the Quality.</summary>
    [JsonPropertyName("Quality")]
    public int? Quality { get; set; }

    /// <summary>Gets or sets the ImageType.</summary>
    [JsonPropertyName("ImageType")]
    public string? ImageType { get; set; }

    /// <summary>Gets or sets the OnePagePerSheet.</summary>
    [JsonPropertyName("OnePagePerSheet")]
    public bool? OnePagePerSheet { get; set; }

    /// <summary>Gets or sets the TiffBinarizationMethod.</summary>
    [JsonPropertyName("TiffBinarizationMethod")]
    public string? TiffBinarizationMethod { get; set; }

}
