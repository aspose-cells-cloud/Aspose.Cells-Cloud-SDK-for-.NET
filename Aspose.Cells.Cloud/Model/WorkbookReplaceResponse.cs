using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the WorkbookReplace Response.</summary>
public class WorkbookReplaceResponse : CellsCloudResponse
{
    /// <summary>Property summary: An integer property named "Matches" with an XmlElement attribute.</summary>
    [JsonPropertyName("Matches")]
    public int? Matches { get; set; }

    /// <summary>Gets or sets the Workbook.</summary>
    [JsonPropertyName("Workbook")]
    public LinkElement? Workbook { get; set; }

}
