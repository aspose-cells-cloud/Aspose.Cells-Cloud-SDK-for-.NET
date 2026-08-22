using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the line shape.</summary>
public class LineShape : Shape
{
    /// <summary>Gets and sets the begin arrow head length of the line.</summary>
    [JsonPropertyName("BeginArrowheadLength")]
    public string? BeginArrowheadLength { get; set; }

    /// <summary>Gets and sets the begin arrow head style of the line.</summary>
    [JsonPropertyName("BeginArrowheadStyle")]
    public string? BeginArrowheadStyle { get; set; }

    /// <summary>Gets and sets the begin arrow head width of the line.</summary>
    [JsonPropertyName("BeginArrowheadWidth")]
    public string? BeginArrowheadWidth { get; set; }

    /// <summary>Gets and sets the end arrow head length of the line.</summary>
    [JsonPropertyName("EndArrowheadLength")]
    public string? EndArrowheadLength { get; set; }

    /// <summary>Gets and sets the end arrow head style of the line.</summary>
    [JsonPropertyName("EndArrowheadStyle")]
    public string? EndArrowheadStyle { get; set; }

    /// <summary>Gets and sets the end arrow head width of the line.</summary>
    [JsonPropertyName("EndArrowheadWidth")]
    public string? EndArrowheadWidth { get; set; }

}
