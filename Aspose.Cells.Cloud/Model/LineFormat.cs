using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents all setting of the line.</summary>
public class LineFormat : FillFormat
{
    /// <summary>Gets and sets the begin arrow length type of the line.</summary>
    [JsonPropertyName("BeginArrowheadLength")]
    public string? BeginArrowheadLength { get; set; }

    /// <summary>Gets and sets the begin arrow type of the line.</summary>
    [JsonPropertyName("BeginArrowheadStyle")]
    public string? BeginArrowheadStyle { get; set; }

    /// <summary>Gets and sets the begin arrow width type of the line.</summary>
    [JsonPropertyName("BeginArrowheadWidth")]
    public string? BeginArrowheadWidth { get; set; }

    /// <summary>Specifies the ending caps.</summary>
    [JsonPropertyName("CapType")]
    public string? CapType { get; set; }

    /// <summary>Specifies the line compound type.</summary>
    [JsonPropertyName("CompoundType")]
    public string? CompoundType { get; set; }

    /// <summary>Specifies the line dash type.</summary>
    [JsonPropertyName("DashStyle")]
    public string? DashStyle { get; set; }

    /// <summary>Gets and sets the end arrow length type of the line.</summary>
    [JsonPropertyName("EndArrowheadLength")]
    public string? EndArrowheadLength { get; set; }

    /// <summary>Gets and sets the end arrow type of the line.</summary>
    [JsonPropertyName("EndArrowheadStyle")]
    public string? EndArrowheadStyle { get; set; }

    /// <summary>Gets and sets the end arrow width type of the line.</summary>
    [JsonPropertyName("EndArrowheadWidth")]
    public string? EndArrowheadWidth { get; set; }

    /// <summary>Specifies the line join type.</summary>
    [JsonPropertyName("JoinType")]
    public string? JoinType { get; set; }

    /// <summary>Gets or sets the weight of the line in unit of points.</summary>
    [JsonPropertyName("Weight")]
    public double? Weight { get; set; }

}
