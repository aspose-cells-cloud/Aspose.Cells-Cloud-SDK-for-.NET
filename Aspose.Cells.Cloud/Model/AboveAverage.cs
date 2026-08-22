using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Describe the AboveAverage conditional formatting rule. This conditional formatting</summary>
public class AboveAverage
{
    /// <summary>Get or set the flag indicating whether the rule is an "above average" rule.</summary>
    [JsonPropertyName("IsAboveAverage")]
    public bool? IsAboveAverage { get; set; }

    /// <summary>Get or set the flag indicating whether the 'aboveAverage' and 'belowAverage' criteria</summary>
    [JsonPropertyName("IsEqualAverage")]
    public bool? IsEqualAverage { get; set; }

    /// <summary>Get or set the number of standard deviations to include above or below the average in the</summary>
    [JsonPropertyName("StdDev")]
    public int? StdDev { get; set; }

}
