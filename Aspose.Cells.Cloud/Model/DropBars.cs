using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the up/down bars in a chart.</summary>
public class DropBars : LinkElement
{
    /// <summary>Gets the .</summary>
    [JsonPropertyName("Area")]
    public Area? Area { get; set; }

    /// <summary>Gets the border .</summary>
    [JsonPropertyName("Border")]
    public Line? Border { get; set; }

}
