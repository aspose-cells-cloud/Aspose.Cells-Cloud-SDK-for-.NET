using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PaginatedSaveOptions model.</summary>
public class PaginatedSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the DefaultFont.</summary>
    [JsonPropertyName("DefaultFont")]
    public string? DefaultFont { get; set; }

    /// <summary>Gets or sets the CheckWorkbookDefaultFont.</summary>
    [JsonPropertyName("CheckWorkbookDefaultFont")]
    public bool? CheckWorkbookDefaultFont { get; set; }

    /// <summary>Gets or sets the CheckFontCompatibility.</summary>
    [JsonPropertyName("CheckFontCompatibility")]
    public bool? CheckFontCompatibility { get; set; }

    /// <summary>Gets or sets the IsFontSubstitutionCharGranularity.</summary>
    [JsonPropertyName("IsFontSubstitutionCharGranularity")]
    public bool? IsFontSubstitutionCharGranularity { get; set; }

    /// <summary>Gets or sets the OnePagePerSheet.</summary>
    [JsonPropertyName("OnePagePerSheet")]
    public bool? OnePagePerSheet { get; set; }

    /// <summary>Gets or sets the AllColumnsInOnePagePerSheet.</summary>
    [JsonPropertyName("AllColumnsInOnePagePerSheet")]
    public bool? AllColumnsInOnePagePerSheet { get; set; }

    /// <summary>Gets or sets the IgnoreError.</summary>
    [JsonPropertyName("IgnoreError")]
    public bool? IgnoreError { get; set; }

    /// <summary>Gets or sets the OutputBlankPageWhenNothingToPrint.</summary>
    [JsonPropertyName("OutputBlankPageWhenNothingToPrint")]
    public bool? OutputBlankPageWhenNothingToPrint { get; set; }

    /// <summary>Gets or sets the PageIndex.</summary>
    [JsonPropertyName("PageIndex")]
    public int? PageIndex { get; set; }

    /// <summary>Gets or sets the PageCount.</summary>
    [JsonPropertyName("PageCount")]
    public int? PageCount { get; set; }

    /// <summary>Gets or sets the PrintingPageType.</summary>
    [JsonPropertyName("PrintingPageType")]
    public string? PrintingPageType { get; set; }

    /// <summary>Gets or sets the GridlineType.</summary>
    [JsonPropertyName("GridlineType")]
    public string? GridlineType { get; set; }

    /// <summary>Gets or sets the TextCrossType.</summary>
    [JsonPropertyName("TextCrossType")]
    public string? TextCrossType { get; set; }

    /// <summary>Gets or sets the DefaultEditLanguage.</summary>
    [JsonPropertyName("DefaultEditLanguage")]
    public string? DefaultEditLanguage { get; set; }

    /// <summary>Gets or sets the EmfRenderSetting.</summary>
    [JsonPropertyName("EmfRenderSetting")]
    public string? EmfRenderSetting { get; set; }

}
