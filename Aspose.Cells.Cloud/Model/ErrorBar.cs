using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents error bar of data series.</summary>
public class ErrorBar : Line
{
    /// <summary>A property named "Link" of type "Link" that can be accessed and modified.</summary>
    [JsonPropertyName("Link")]
    public Link? Link { get; set; }

    /// <summary>Represents amount of error bar.</summary>
    [JsonPropertyName("Amount")]
    public double? Amount { get; set; }

    /// <summary>Represents error bar display type.</summary>
    [JsonPropertyName("DisplayType")]
    public string? DisplayType { get; set; }

    /// <summary>Represents negative error amount when error bar type is Custom.</summary>
    [JsonPropertyName("MinusValue")]
    public string? MinusValue { get; set; }

    /// <summary>Represents positive error amount when error bar type is Custom.</summary>
    [JsonPropertyName("PlusValue")]
    public string? PlusValue { get; set; }

    /// <summary>Indicates if formatting error bars with a T-top.</summary>
    [JsonPropertyName("ShowMarkerTTop")]
    public bool? ShowMarkerTTop { get; set; }

    /// <summary>Represents error bar amount type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

}
