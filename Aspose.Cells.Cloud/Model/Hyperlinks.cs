using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of  objects.</summary>
public class Hyperlinks : LinkElement
{
    /// <summary>Property Summary: An integer property named Count with an XML element name "count."</summary>
    [JsonPropertyName("Count")]
    public int? Count { get; set; }

    /// <summary>Gets or sets the HyperlinkList.</summary>
    [JsonPropertyName("HyperlinkList")]
    public List<LinkElement>? HyperlinkList { get; set; }

}
