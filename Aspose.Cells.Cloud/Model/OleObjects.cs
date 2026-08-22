using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents embedded OLE objects.</summary>
public class OleObjects : LinkElement
{
    /// <summary>Property Summary: Contains a list of elements identified as "oleobject" within XML data.</summary>
    [JsonPropertyName("OleObjectList")]
    public List<LinkElement>? OleObjectList { get; set; }

}
