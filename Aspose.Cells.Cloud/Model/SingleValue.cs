using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents single value.</summary>
public class SingleValue
{
    /// <summary>Gets or sets the Value.</summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

    /// <summary>Represents value type.</summary>
    [JsonPropertyName("ValueType")]
    public object? ValueType { get; set; }

}
