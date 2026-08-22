using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a vertical page break.</summary>
public class VerticalPageBreak
{
    /// <summary>Gets the column index of the vertical page break.</summary>
    [JsonPropertyName("Column")]
    public int? Column { get; set; }

    /// <summary>Gets the end row index of the vertical page break.</summary>
    [JsonPropertyName("EndRow")]
    public int? EndRow { get; set; }

    /// <summary>Gets the start row index of the vertical page break.</summary>
    [JsonPropertyName("StartRow")]
    public int? StartRow { get; set; }

}
