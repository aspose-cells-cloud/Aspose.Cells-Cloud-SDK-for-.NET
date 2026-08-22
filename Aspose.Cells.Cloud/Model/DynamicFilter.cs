using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the dynamic filter.</summary>
public class DynamicFilter
{
    /// <summary>Gets and sets the dynamic filter type.</summary>
    [JsonPropertyName("DynamicFilterType")]
    public string? DynamicFilterType { get; set; }

    /// <summary>Gets and sets the dynamic filter max value.</summary>
    [JsonPropertyName("MaxValue")]
    public object? MaxValue { get; set; }

    /// <summary>Gets and sets the dynamic filter value.</summary>
    [JsonPropertyName("Value")]
    public object? Value { get; set; }

}
