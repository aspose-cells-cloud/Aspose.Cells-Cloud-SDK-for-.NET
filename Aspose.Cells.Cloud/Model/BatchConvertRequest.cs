using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates batch convert file request</summary>
public class BatchConvertRequest
{
    /// <summary>The directory stores files that need to format conversion.</summary>
    [JsonPropertyName("SourceFolder")]
    public string? SourceFolder { get; set; }

    /// <summary>Aspose Cloud storage name.</summary>
    [JsonPropertyName("SourceStorage")]
    public string? SourceStorage { get; set; }

    /// <summary>Indicates the match condition that needs to be processed for the file name.</summary>
    [JsonPropertyName("MatchCondition")]
    public MatchConditionRequest? MatchCondition { get; set; }

    /// <summary>Gets or sets the Format.</summary>
    [JsonPropertyName("Format")]
    public string? Format { get; set; }

    /// <summary>The directory that stores files whose format conversion was successful.</summary>
    [JsonPropertyName("OutFolder")]
    public string? OutFolder { get; set; }

    /// <summary>Aspose Cloud storage name.</summary>
    [JsonPropertyName("OutStorage")]
    public string? OutStorage { get; set; }

    /// <summary>The regional settings for workbook.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

    /// <summary>A nullable Boolean property that determines whether the content should be fit to the entire page width on each sheet.</summary>
    [JsonPropertyName("PageWideFitOnPerSheet")]
    public bool? PageWideFitOnPerSheet { get; set; }

    /// <summary>Gets or sets the PageTallFitOnPerSheet.</summary>
    [JsonPropertyName("PageTallFitOnPerSheet")]
    public bool? PageTallFitOnPerSheet { get; set; }

    /// <summary>Indicates save options.</summary>
    [JsonPropertyName("SaveOptions")]
    public SaveOptions? SaveOptions { get; set; }

}
