using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the gradient fill.</summary>
public class GradientFill
{
    /// <summary>Gets the gradient fill type.</summary>
    [JsonPropertyName("FillType")]
    public string? FillType { get; set; }

    /// <summary>Gets the gradient direction type.</summary>
    [JsonPropertyName("DirectionType")]
    public string? DirectionType { get; set; }

    /// <summary>The angle of linear fill.</summary>
    [JsonPropertyName("Angle")]
    public double? Angle { get; set; }

    /// <summary>Represents the gradient stop collection.</summary>
    [JsonPropertyName("GradientStops")]
    public List<GradientFillStop>? GradientStops { get; set; }

}
