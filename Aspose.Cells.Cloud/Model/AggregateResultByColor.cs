using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the AggregateResultByColor model.</summary>
public class AggregateResultByColor
{
    /// <summary>Gets or sets the AggregateOperation.</summary>
    [JsonPropertyName("AggregateOperation")]
    public string? AggregateOperation { get; set; }

    /// <summary>Gets or sets the ColorName.</summary>
    [JsonPropertyName("ColorName")]
    public string? ColorName { get; set; }

    /// <summary>Gets or sets the Count.</summary>
    [JsonPropertyName("Count")]
    public int? Count { get; set; }

    /// <summary>Gets or sets the Sum.</summary>
    [JsonPropertyName("Sum")]
    public double? Sum { get; set; }

    /// <summary>Gets or sets the MaxValue.</summary>
    [JsonPropertyName("MaxValue")]
    public double? MaxValue { get; set; }

    /// <summary>Gets or sets the MinValue.</summary>
    [JsonPropertyName("MinValue")]
    public double? MinValue { get; set; }

    /// <summary>Gets or sets the AverageValue.</summary>
    [JsonPropertyName("AverageValue")]
    public double? AverageValue { get; set; }

}
