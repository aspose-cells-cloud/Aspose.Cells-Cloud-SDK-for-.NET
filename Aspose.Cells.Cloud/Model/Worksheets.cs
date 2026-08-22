using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of  objects.</summary>
public class Worksheets : LinkElement
{
    /// <summary>A property named "WorksheetList" that contains a list of elements with the XML element name "worksheet".</summary>
    [JsonPropertyName("WorksheetList")]
    public List<LinkElement>? WorksheetList { get; set; }

}
