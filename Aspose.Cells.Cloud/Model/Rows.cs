using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Collects the  objects that represent the individual rows in a worksheet.</summary>
public class Rows : LinkElement
{
    /// <summary>This property allows access to set and retrieve the maximum row value in the class.</summary>
    [JsonPropertyName("MaxRow")]
    public int? MaxRow { get; set; }

    /// <summary>Gets or sets the RowsCount.</summary>
    [JsonPropertyName("RowsCount")]
    public int? RowsCount { get; set; }

    /// <summary>Gets or sets the RowsList.</summary>
    [JsonPropertyName("RowsList")]
    public List<LinkElement>? RowsList { get; set; }

}
