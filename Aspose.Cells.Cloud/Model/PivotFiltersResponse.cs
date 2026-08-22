using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PivotFilters Response.</summary>
public class PivotFiltersResponse : CellsCloudResponse
{
    /// <summary>Property summary: Contains a list of PivotFilter objects.</summary>
    [JsonPropertyName("PivotFilters")]
    public List<PivotFilter>? PivotFilters { get; set; }

}
