using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents the walls of a 3-D chart.</summary>
public class Walls : Floor
{
    /// <summary>Gets the x coordinate of the left-bottom corner of Wall center in units of 1/4000 of chart's width after calls Chart.Calculate() method.</summary>
    [JsonPropertyName("CenterX")]
    public int? CenterX { get; set; }

    /// <summary>Gets the y coordinate of the left-bottom corner of Wall center in units of 1/4000 of chart's height after calls Chart.Calculate() method.</summary>
    [JsonPropertyName("CenterY")]
    public int? CenterY { get; set; }

    /// <summary>Gets the depth front to back in units of 1/4000 of chart's width after calls Chart.Calculate() method.</summary>
    [JsonPropertyName("Depth")]
    public int? Depth { get; set; }

    /// <summary>Gets the height of top to bottom in units of 1/4000 of chart's height after calls Chart.Calculate() method.</summary>
    [JsonPropertyName("Height")]
    public int? Height { get; set; }

    /// <summary>Gets the width of left to right in units of 1/4000 of chart's width after calls Chart.Calculate() method.</summary>
    [JsonPropertyName("Width")]
    public int? Width { get; set; }

}
