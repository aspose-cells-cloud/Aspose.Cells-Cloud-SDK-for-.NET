using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of cell relevant objects, such as Aspose.Cells.Cell, Aspose.Cells.Row, ...etc.</summary>
public class Cells : LinkElement
{
    /// <summary>Maximum row index of cell which contains data or style.</summary>
    [JsonPropertyName("MaxRow")]
    public int? MaxRow { get; set; }

    /// <summary>Maximum column index of those cells that have been instantiated in the collection(does not include the column</summary>
    [JsonPropertyName("MaxColumn")]
    public int? MaxColumn { get; set; }

    /// <summary>The class has a public property "CellCount" of type integer that can be read and modified.</summary>
    [JsonPropertyName("CellCount")]
    public int? CellCount { get; set; }

    /// <summary>Gets the collection of  objects that represents the individual rows in this worksheet.</summary>
    [JsonPropertyName("Rows")]
    public LinkElement? Rows { get; set; }

    /// <summary>Gets the collection of  objects that represents the individual columns in this worksheet.</summary>
    [JsonPropertyName("Columns")]
    public LinkElement? Columns { get; set; }

    /// <summary>Gets or sets the CellList.</summary>
    [JsonPropertyName("CellList")]
    public List<LinkElement>? CellList { get; set; }

}
