using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Workbook Response.</summary>
public class WorkbookResponse : CellsCloudResponse
{
    /// <summary>Workbook property of the class allows access to and modification of a Workbook object.</summary>
    [JsonPropertyName("Workbook")]
    public Workbook? Workbook { get; set; }

}
