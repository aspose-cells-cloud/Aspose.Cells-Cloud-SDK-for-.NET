using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents page break operate parameter.</summary>
public class PageBreakOperateParameter : OperateParameter
{
    /// <summary>Represents page break type.</summary>
    [JsonPropertyName("PageBreakType")]
    public string? PageBreakType { get; set; }

    /// <summary>Represents page break index.</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>Represents row index of page break.</summary>
    [JsonPropertyName("Row")]
    public int? Row { get; set; }

    /// <summary>Represents column index of page break.</summary>
    [JsonPropertyName("Column")]
    public int? Column { get; set; }

    /// <summary>Represents start row index of page break.</summary>
    [JsonPropertyName("StartIndex")]
    public int? StartIndex { get; set; }

    /// <summary>Represents end row index of page break.</summary>
    [JsonPropertyName("EndIndex")]
    public int? EndIndex { get; set; }

}
