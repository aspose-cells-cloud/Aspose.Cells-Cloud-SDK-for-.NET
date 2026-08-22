using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents time period format condition.</summary>
public class TimePeriodFormatCondition
{
    /// <summary>The applicable time period in a "date occurring…" conditional formatting</summary>
    [JsonPropertyName("TimePeriod")]
    public string? TimePeriod { get; set; }

}
