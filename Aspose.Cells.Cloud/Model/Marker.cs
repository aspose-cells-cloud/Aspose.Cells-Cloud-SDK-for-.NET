using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the marker in a line chart, scatter chart, or radar chart.</summary>
public class Marker
{
    /// <summary>Gets the border.</summary>
    [JsonPropertyName("Border")]
    public Line? Border { get; set; }

    /// <summary>Gets the area.</summary>
    [JsonPropertyName("Area")]
    public Area? Area { get; set; }

    /// <summary>Represents the marker size in unit of points. Applies to line chart, scatter chart, or radar chart.</summary>
    [JsonPropertyName("MarkerSize")]
    public int? MarkerSize { get; set; }

    /// <summary>Represents the marker style. Applies to line chart, scatter chart, or radar chart.</summary>
    [JsonPropertyName("MarkerStyle")]
    public string? MarkerStyle { get; set; }

}
