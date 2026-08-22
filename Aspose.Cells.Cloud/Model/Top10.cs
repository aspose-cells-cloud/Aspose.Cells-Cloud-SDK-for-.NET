using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Describe the Top10 conditional formatting rule. This conditional formatting</summary>
public class Top10
{
    /// <summary>Get or set whether a "top/bottom n" rule is a "bottom n" rule.</summary>
    [JsonPropertyName("IsBottom")]
    public bool? IsBottom { get; set; }

    /// <summary>Get or set whether a "top/bottom n" rule is a "top/bottom n percent" rule.</summary>
    [JsonPropertyName("IsPercent")]
    public bool? IsPercent { get; set; }

    /// <summary>Get or set the value of "n" in a "top/bottom n" conditional formatting rule.</summary>
    [JsonPropertyName("Rank")]
    public int? Rank { get; set; }

}
