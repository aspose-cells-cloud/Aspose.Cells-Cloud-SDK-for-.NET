using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Describes the values of the interpolation points in a gradient scale, dataBar or iconSet.</summary>
public class ConditionalFormattingValue
{
    /// <summary>Get or set the Greater Than Or Equal flag.</summary>
    [JsonPropertyName("IsGTE")]
    public bool? IsGTE { get; set; }

    /// <summary>Get or set the type of this conditional formatting value object.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Get or set the value of this conditional formatting value object.</summary>
    [JsonPropertyName("Value")]
    public object? Value { get; set; }

}
