using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the datetime's group setting.</summary>
public class DateTimeGroupItem : MultipleFilter
{
    /// <summary>Gets and sets the group type.</summary>
    [JsonPropertyName("DateTimeGroupingType")]
    public string? DateTimeGroupingType { get; set; }

    /// <summary>Gets and sets the day of the grouped date time.</summary>
    [JsonPropertyName("Day")]
    public int? Day { get; set; }

    /// <summary>Gets and sets the hour of the grouped date time.</summary>
    [JsonPropertyName("Hour")]
    public int? Hour { get; set; }

    /// <summary>Gets and sets the minute of the grouped date time.</summary>
    [JsonPropertyName("Minute")]
    public int? Minute { get; set; }

    /// <summary>Gets and sets the month of the grouped date time.</summary>
    [JsonPropertyName("Month")]
    public int? Month { get; set; }

    /// <summary>Gets and sets the second of the grouped date time.</summary>
    [JsonPropertyName("Second")]
    public int? Second { get; set; }

    /// <summary>Gets and sets the year of the grouped date time.</summary>
    [JsonPropertyName("Year")]
    public int? Year { get; set; }

}
