using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the top 10 filter.</summary>
public class Top10Filter
{
    /// <summary>An integer property named FieldIndex that can be accessed and modified.</summary>
    [JsonPropertyName("FieldIndex")]
    public int? FieldIndex { get; set; }

    /// <summary>Gets or sets the Criteria.</summary>
    [JsonPropertyName("Criteria")]
    public string? Criteria { get; set; }

    /// <summary>Indicates whether the items is percent.</summary>
    [JsonPropertyName("IsPercent")]
    public bool? IsPercent { get; set; }

    /// <summary>Indicates whether it's top filter.</summary>
    [JsonPropertyName("IsTop")]
    public bool? IsTop { get; set; }

    /// <summary>Gets and sets the items of the filter.</summary>
    [JsonPropertyName("Items")]
    public int? Items { get; set; }

}
