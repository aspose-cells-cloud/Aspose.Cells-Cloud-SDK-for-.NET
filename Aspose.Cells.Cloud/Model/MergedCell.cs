using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm happy to help! Could you please provide me with the features you would like me to summarize for the class?</summary>
public class MergedCell : LinkElement
{
    /// <summary>An integer property named "EndColumn" with the XML element name "endcolumn".</summary>
    [JsonPropertyName("EndColumn")]
    public int? EndColumn { get; set; }

    /// <summary>Gets or sets the EndRow.</summary>
    [JsonPropertyName("EndRow")]
    public int? EndRow { get; set; }

    /// <summary>Gets or sets the StartColumn.</summary>
    [JsonPropertyName("StartColumn")]
    public int? StartColumn { get; set; }

    /// <summary>Gets or sets the StartRow.</summary>
    [JsonPropertyName("StartRow")]
    public int? StartRow { get; set; }

}
