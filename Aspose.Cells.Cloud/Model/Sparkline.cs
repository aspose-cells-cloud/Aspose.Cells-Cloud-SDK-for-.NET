using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>A sparkline represents a tiny chart or graphic in a worksheet cell that provides a visual representation of data.</summary>
public class Sparkline
{
    /// <summary>Gets the column index of the sparkline.</summary>
    [JsonPropertyName("Column")]
    public int? Column { get; set; }

    /// <summary>Represents the data range of the sparkline.</summary>
    [JsonPropertyName("DataRange")]
    public string? DataRange { get; set; }

    /// <summary>Gets the row index of the sparkline.</summary>
    [JsonPropertyName("Row")]
    public int? Row { get; set; }

}
