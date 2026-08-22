using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates batch lock file request</summary>
public class BatchLockRequest
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

    /// <summary>Lock file with password</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

    /// <summary>The directory that stores files whose format conversion was successful.</summary>
    [JsonPropertyName("OutFolder")]
    public string? OutFolder { get; set; }

    /// <summary>Aspose Cloud storage name</summary>
    [JsonPropertyName("OutStorage")]
    public string? OutStorage { get; set; }

}
