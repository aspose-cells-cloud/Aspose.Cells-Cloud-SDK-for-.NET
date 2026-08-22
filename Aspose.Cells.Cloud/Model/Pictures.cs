using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates a collection of  objects.</summary>
public class Pictures : LinkElement
{
    /// <summary>Property Summary: Contains a list of elements with the XML element name "picture."</summary>
    [JsonPropertyName("PictureList")]
    public List<LinkElement>? PictureList { get; set; }

}
