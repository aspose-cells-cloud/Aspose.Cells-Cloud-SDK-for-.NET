using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Columns model.</summary>
public class Columns : LinkElement
{
    /// <summary>The max column index.</summary>
    [JsonPropertyName("MaxColumn")]
    public int? MaxColumn { get; set; }

    /// <summary>Gets or sets the ColumnsCount.</summary>
    [JsonPropertyName("ColumnsCount")]
    public int? ColumnsCount { get; set; }

    /// <summary>Gets or sets the ColumnsList.</summary>
    [JsonPropertyName("ColumnsList")]
    public List<LinkElement>? ColumnsList { get; set; }

}
