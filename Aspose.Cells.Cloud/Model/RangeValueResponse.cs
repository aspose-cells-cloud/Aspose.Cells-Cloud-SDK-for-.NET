using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the RangeValue Response.</summary>
public class RangeValueResponse : CellsCloudResponse
{
    /// <summary>Property Summary: Contains a list of elements labeled as "Cell".</summary>
    [JsonPropertyName("CellsList")]
    public List<Cell>? CellsList { get; set; }

}
