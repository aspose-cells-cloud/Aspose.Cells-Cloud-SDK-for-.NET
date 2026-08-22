using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Unpivot column.</summary>
public class UnpivotColumn : AppliedOperate
{
    /// <summary>Indicates unpivot column names.</summary>
    [JsonPropertyName("UnpivotColumnNames")]
    public List<string>? UnpivotColumnNames { get; set; }

    /// <summary>Indicates the column is used to store the name of unpivot columns.</summary>
    [JsonPropertyName("ColumnMapName")]
    public string? ColumnMapName { get; set; }

    /// <summary>Indicates the column is used to store the value of unpivot columns.</summary>
    [JsonPropertyName("ValueMapName")]
    public string? ValueMapName { get; set; }

}
