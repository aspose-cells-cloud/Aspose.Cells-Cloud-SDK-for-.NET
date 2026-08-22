using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the WorksheetReplace Response.</summary>
public class WorksheetReplaceResponse : CellsCloudResponse
{
    /// <summary>"An integer property named Matches decorated with the XmlElement attribute."</summary>
    [JsonPropertyName("Matches")]
    public int? Matches { get; set; }

    /// <summary>Gets or sets the Worksheet.</summary>
    [JsonPropertyName("Worksheet")]
    public LinkElement? Worksheet { get; set; }

}
