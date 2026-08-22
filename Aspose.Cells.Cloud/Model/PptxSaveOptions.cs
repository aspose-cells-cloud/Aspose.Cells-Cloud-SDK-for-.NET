using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PptxSaveOptions model.</summary>
public class PptxSaveOptions : PaginatedSaveOptions
{
    /// <summary>Gets or sets the IgnoreHiddenRows.</summary>
    [JsonPropertyName("IgnoreHiddenRows")]
    public bool? IgnoreHiddenRows { get; set; }

    /// <summary>Gets or sets the AdjustFontSizeForRowType.</summary>
    [JsonPropertyName("AdjustFontSizeForRowType")]
    public string? AdjustFontSizeForRowType { get; set; }

    /// <summary>Gets or sets the ExportViewType.</summary>
    [JsonPropertyName("ExportViewType")]
    public string? ExportViewType { get; set; }

}
