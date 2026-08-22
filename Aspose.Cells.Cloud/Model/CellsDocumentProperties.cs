using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Excel properties</summary>
public class CellsDocumentProperties
{
    /// <summary>Document property list.</summary>
    [JsonPropertyName("DocumentPropertyList")]
    public List<CellsDocumentProperty>? DocumentPropertyList { get; set; }

}
