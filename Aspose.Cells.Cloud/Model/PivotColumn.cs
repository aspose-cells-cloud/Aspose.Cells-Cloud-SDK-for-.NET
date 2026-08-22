using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents pivot column for data table.</summary>
public class PivotColumn : AppliedOperate
{
    /// <summary>Represents pivot column name.</summary>
    [JsonPropertyName("PivotColumnName")]
    public string? PivotColumnName { get; set; }

    /// <summary>Represents column name that sets the column's value to the value of the pivot column.</summary>
    [JsonPropertyName("ValueColumnNames")]
    public List<string>? ValueColumnNames { get; set; }

}
