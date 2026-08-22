using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the collection of all the PivotTable objects on the specified worksheet.</summary>
public class PivotTables : LinkElement
{
    /// <summary>Xml property "PivotTableList" of the class contains a list of "LinkElement" objects with the element name "PivotTable".</summary>
    [JsonPropertyName("PivotTableList")]
    public List<LinkElement>? PivotTableList { get; set; }

}
