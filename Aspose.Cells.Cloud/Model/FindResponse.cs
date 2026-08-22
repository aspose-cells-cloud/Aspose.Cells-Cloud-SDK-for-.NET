using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Find Response.</summary>
public class FindResponse : CellsCloudResponse
{
    /// <summary>Property Summary: This property is annotated with the XML element name "count" and represents an integer value.</summary>
    [JsonPropertyName("Count")]
    public int? Count { get; set; }

    /// <summary>Gets or sets the TextItems.</summary>
    [JsonPropertyName("TextItems")]
    public TextItems? TextItems { get; set; }

}
