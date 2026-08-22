using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Columns</summary>
public class Columns : LinkElement
{
    /// <summary>The max column index.</summary>
    [JsonPropertyName("MaxColumn")]
    public int? MaxColumn { get; set; }

    /// <summary>Column count.</summary>
    [JsonPropertyName("ColumnsCount")]
    public int? ColumnsCount { get; set; }

    /// <summary>Columns list.</summary>
    [JsonPropertyName("ColumnsList")]
    public List<LinkElement>? ColumnsList { get; set; }

}
