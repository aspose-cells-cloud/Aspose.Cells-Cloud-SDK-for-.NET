using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents pivot table operate parameter.</summary>
public class PivotTableOperateParameter : OperateParameter
{
    /// <summary>Represents source data of pivot table.</summary>
    [JsonPropertyName("SourceData")]
    public string? SourceData { get; set; }

    /// <summary>Represents start cell name of the pivot table.</summary>
    [JsonPropertyName("DestCellName")]
    public string? DestCellName { get; set; }

    /// <summary>Represents table name of pivot table.</summary>
    [JsonPropertyName("TableName")]
    public string? TableName { get; set; }

    /// <summary>Represents whether the same source is used.</summary>
    [JsonPropertyName("UseSameSource")]
    public bool? UseSameSource { get; set; }

    /// <summary>Represents pivot table index.</summary>
    [JsonPropertyName("PivotTableIndex")]
    public int? PivotTableIndex { get; set; }

    /// <summary>Represents pivot row fields.</summary>
    [JsonPropertyName("PivotFieldRows")]
    public List<int>? PivotFieldRows { get; set; }

    /// <summary>Represents pivot column fields.</summary>
    [JsonPropertyName("PivotFieldColumns")]
    public List<int>? PivotFieldColumns { get; set; }

    /// <summary>Represents pivot data field.</summary>
    [JsonPropertyName("PivotFieldData")]
    public List<int>? PivotFieldData { get; set; }

}
