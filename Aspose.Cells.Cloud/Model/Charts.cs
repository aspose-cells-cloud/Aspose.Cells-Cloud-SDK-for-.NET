using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of  objects.</summary>
public class Charts : LinkElement
{
    /// <summary>A property named ChartList of type List LinkElement  that is publicly accessible with both read and write capabilities.</summary>
    [JsonPropertyName("ChartList")]
    public List<LinkElement>? ChartList { get; set; }

}
