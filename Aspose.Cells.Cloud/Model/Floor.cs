using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents the floor of a 3-D chart.</summary>
public class Floor : Area
{
    /// <summary>Gets or sets the border .</summary>
    [JsonPropertyName("Border")]
    public Line? Border { get; set; }

}
