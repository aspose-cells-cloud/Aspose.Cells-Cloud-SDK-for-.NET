using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Worksheets Response.</summary>
public class WorksheetsResponse : CellsCloudResponse
{
    /// <summary>Property `Worksheets` of type `Worksheets` with the XML element name "worksheets" is defined in the class.</summary>
    [JsonPropertyName("Worksheets")]
    public Worksheets? Worksheets { get; set; }

}
