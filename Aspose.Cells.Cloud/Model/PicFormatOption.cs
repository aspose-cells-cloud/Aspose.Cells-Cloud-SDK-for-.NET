using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents picture format option</summary>
public class PicFormatOption
{
    /// <summary>Gets or sets the picture fill type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets how many the picture stack and scale with.</summary>
    [JsonPropertyName("Scale")]
    public double? Scale { get; set; }

    /// <summary>Gets or sets the left offset for stretching picture.</summary>
    [JsonPropertyName("Left")]
    public double? Left { get; set; }

    /// <summary>Gets or sets the right offset for stretching picture.</summary>
    [JsonPropertyName("Right")]
    public double? Right { get; set; }

    /// <summary>Gets or sets the top offset for stretching picture.</summary>
    [JsonPropertyName("Top")]
    public double? Top { get; set; }

    /// <summary>Gets or sets the bottom offset for stretching picture.</summary>
    [JsonPropertyName("Bottom")]
    public double? Bottom { get; set; }

}
