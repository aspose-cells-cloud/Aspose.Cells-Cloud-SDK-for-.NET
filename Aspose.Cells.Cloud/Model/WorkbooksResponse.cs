using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Workbooks Response.</summary>
public class WorkbooksResponse : CellsCloudResponse
{
    /// <summary>Property Summary: Contains a list of "Workbook" elements under the "Workbooks" array in XML format.</summary>
    [JsonPropertyName("Workbooks")]
    public List<LinkElement>? Workbooks { get; set; }

}
