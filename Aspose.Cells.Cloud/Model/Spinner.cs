using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Forms control: Spinner.</summary>
public class Spinner : Shape
{
    /// <summary>Gets or sets the current value.</summary>
    [JsonPropertyName("CurrentValue")]
    public int? CurrentValue { get; set; }

    /// <summary>Gets or sets the amount that the scroll bar or spinner is incremented a line scroll.</summary>
    [JsonPropertyName("IncrementalChange")]
    public int? IncrementalChange { get; set; }

    /// <summary>Gets or sets the maximum value of a scroll bar or spinner range.</summary>
    [JsonPropertyName("Max")]
    public int? Max { get; set; }

    /// <summary>Gets or sets the minimum value of a scroll bar or spinner range.</summary>
    [JsonPropertyName("Min")]
    public int? Min { get; set; }

    /// <summary>Indicates whether the shape has 3-D shading.</summary>
    [JsonPropertyName("Shadow")]
    public bool? Shadow { get; set; }

}
