using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates create pivot table request</summary>
public class CreatePivotTableRequest
{
    /// <summary>Pivot table name</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>The data for the new PivotTable cache.</summary>
    [JsonPropertyName("SourceData")]
    public string? SourceData { get; set; }

    /// <summary>The cell in the upper-left corner of the PivotTable report's destination range.</summary>
    [JsonPropertyName("DestCellName")]
    public string? DestCellName { get; set; }

    /// <summary>Indicates whether using same data source when another existing pivot table has used this data source.If the property is true, it will save memory.</summary>
    [JsonPropertyName("UseSameSource")]
    public bool? UseSameSource { get; set; }

    /// <summary>Represents row fields in a PivotTable report.</summary>
    [JsonPropertyName("PivotFieldRows")]
    public List<int>? PivotFieldRows { get; set; }

    /// <summary>Represents column fields in a PivotTable report.</summary>
    [JsonPropertyName("PivotFieldColumns")]
    public List<int>? PivotFieldColumns { get; set; }

    /// <summary>Represents data fields in a PivotTable report.</summary>
    [JsonPropertyName("PivotFieldData")]
    public List<int>? PivotFieldData { get; set; }

}
