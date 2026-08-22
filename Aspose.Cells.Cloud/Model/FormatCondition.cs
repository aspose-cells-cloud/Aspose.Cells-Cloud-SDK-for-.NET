using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents conditional formatting condition.</summary>
public class FormatCondition : LinkElement
{
    /// <summary>The priority of this conditional formatting rule. This value is used to determine which</summary>
    [JsonPropertyName("Priority")]
    public int? Priority { get; set; }

    /// <summary>Gets and sets whether the conditional format Type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>True, no rules with lower priority may be applied over this rule, when this rule evaluates to true.</summary>
    [JsonPropertyName("StopIfTrue")]
    public bool? StopIfTrue { get; set; }

    /// <summary>Get the conditional formatting's "AboveAverage" instance.</summary>
    [JsonPropertyName("AboveAverage")]
    public AboveAverage? AboveAverage { get; set; }

    /// <summary>Get the conditional formatting's "ColorScale" instance.</summary>
    [JsonPropertyName("ColorScale")]
    public ColorScale? ColorScale { get; set; }

    /// <summary>Get the conditional formatting's "DataBar" instance.</summary>
    [JsonPropertyName("DataBar")]
    public DataBar? DataBar { get; set; }

    /// <summary>Gets and sets the value or expression associated with conditional formatting.</summary>
    [JsonPropertyName("Formula1")]
    public string? Formula1 { get; set; }

    /// <summary>Gets and sets the value or expression associated with conditional formatting.</summary>
    [JsonPropertyName("Formula2")]
    public string? Formula2 { get; set; }

    /// <summary>Get the conditional formatting's "IconSet" instance.</summary>
    [JsonPropertyName("IconSet")]
    public IconSet? IconSet { get; set; }

    /// <summary>Gets and sets the conditional format operator type.</summary>
    [JsonPropertyName("Operator")]
    public string? Operator { get; set; }

    /// <summary>Gets or setts style of conditional formatted cell ranges.</summary>
    [JsonPropertyName("Style")]
    public Style? Style { get; set; }

    /// <summary>The text value in a "text contains" conditional formatting rule.</summary>
    [JsonPropertyName("Text")]
    public string? Text { get; set; }

    /// <summary>The applicable time period in a "date occurring…" conditional formatting rule.</summary>
    [JsonPropertyName("TimePeriod")]
    public string? TimePeriod { get; set; }

    /// <summary>Get the conditional formatting's "Top10" instance.</summary>
    [JsonPropertyName("Top10")]
    public Top10? Top10 { get; set; }

}
