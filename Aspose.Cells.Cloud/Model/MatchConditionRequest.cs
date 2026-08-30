using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates the match condition that needs to be processed for the file name.</summary>
public class MatchConditionRequest
{
    /// <summary>Gets or sets the RegexPattern.</summary>
    [JsonPropertyName("RegexPattern")]
    public string? RegexPattern { get; set; }

    /// <summary>Gets or sets the FullMatchConditions.</summary>
    [JsonPropertyName("FullMatchConditions")]
    public List<string>? FullMatchConditions { get; set; }

}
