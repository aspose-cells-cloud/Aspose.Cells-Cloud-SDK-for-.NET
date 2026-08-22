using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents chart operate parameter.</summary>
public class ChartOperateParameter : OperateParameter
{
    /// <summary>Represents chart index.</summary>
    [JsonPropertyName("ChartIndex")]
    public int? ChartIndex { get; set; }

    /// <summary>Represents chart type.</summary>
    [JsonPropertyName("ChartType")]
    public string? ChartType { get; set; }

    /// <summary>Represents upper left row index of chart.</summary>
    [JsonPropertyName("UpperLeftRow")]
    public int? UpperLeftRow { get; set; }

    /// <summary>Represents upper left column index of chart.</summary>
    [JsonPropertyName("UpperLeftColumn")]
    public int? UpperLeftColumn { get; set; }

    /// <summary>Represents lower right row index of chart.</summary>
    [JsonPropertyName("LowerRightRow")]
    public int? LowerRightRow { get; set; }

    /// <summary>Represents lower right column index of chart.</summary>
    [JsonPropertyName("LowerRightColumn")]
    public int? LowerRightColumn { get; set; }

    /// <summary>Represents chart area.</summary>
    [JsonPropertyName("Area")]
    public string? Area { get; set; }

    /// <summary>Represents whether to plot the series from a range of cell values by row or by column.</summary>
    [JsonPropertyName("IsVertical")]
    public bool? IsVertical { get; set; }

    /// <summary>Represents chart category data.</summary>
    [JsonPropertyName("CategoryData")]
    public string? CategoryData { get; set; }

    /// <summary>Represents whether auto get serial name.</summary>
    [JsonPropertyName("IsAutoGetSerialName")]
    public bool? IsAutoGetSerialName { get; set; }

    /// <summary>Represents chart title.</summary>
    [JsonPropertyName("Title")]
    public string? Title { get; set; }

}
