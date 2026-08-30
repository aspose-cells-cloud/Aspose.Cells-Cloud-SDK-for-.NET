using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the BatchSplitRequest model.</summary>
public class BatchSplitRequest
{
    /// <summary>The directory stores files that need to format conversion.</summary>
    [JsonPropertyName("SourceFolder")]
    public string? SourceFolder { get; set; }

    /// <summary>Aspose Cloud storage name</summary>
    [JsonPropertyName("SourceStorage")]
    public string? SourceStorage { get; set; }

    /// <summary>Indicates the match condition that needs to be processed for the file name.</summary>
    [JsonPropertyName("MatchCondition")]
    public MatchConditionRequest? MatchCondition { get; set; }

    /// <summary>Output file format</summary>
    [JsonPropertyName("Format")]
    public string? Format { get; set; }

    /// <summary>From worksheet index of workbook.</summary>
    [JsonPropertyName("FromIndex")]
    public int? FromIndex { get; set; }

    /// <summary>To worksheet index of workbook.</summary>
    [JsonPropertyName("ToIndex")]
    public int? ToIndex { get; set; }

    /// <summary>The directory that stores files whose format conversion was successful.</summary>
    [JsonPropertyName("OutFolder")]
    public string? OutFolder { get; set; }

    /// <summary>Aspose Cloud storage name.</summary>
    [JsonPropertyName("OutStorage")]
    public string? OutStorage { get; set; }

    /// <summary>The regional settings for workbook.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

    /// <summary>Indicates save options.</summary>
    [JsonPropertyName("SaveOptions")]
    public SaveOptions? SaveOptions { get; set; }

}
