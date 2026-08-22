using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Describe the ColorScale conditional formatting rule. This conditional formatting</summary>
public class ColorScale
{
    /// <summary>Get or set this ColorScale's max value object.</summary>
    [JsonPropertyName("MaxCfvo")]
    public ConditionalFormattingValue? MaxCfvo { get; set; }

    /// <summary>Get or set the gradient color for the maximum value in the range.</summary>
    [JsonPropertyName("MaxColor")]
    public Color? MaxColor { get; set; }

    /// <summary>Get or set this ColorScale's mid value object.</summary>
    [JsonPropertyName("MidCfvo")]
    public ConditionalFormattingValue? MidCfvo { get; set; }

    /// <summary>Get or set the gradient color for the middle value in the range.</summary>
    [JsonPropertyName("MidColor")]
    public Color? MidColor { get; set; }

    /// <summary>Get or set this ColorScale's min value object.</summary>
    [JsonPropertyName("MinCfvo")]
    public ConditionalFormattingValue? MinCfvo { get; set; }

    /// <summary>Get or set the gradient color for the minimum value in the range.</summary>
    [JsonPropertyName("MinColor")]
    public Color? MinColor { get; set; }

}
