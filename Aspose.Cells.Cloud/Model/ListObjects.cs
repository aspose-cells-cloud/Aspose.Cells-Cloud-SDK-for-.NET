using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a collection of  objects in the worksheet.</summary>
public class ListObjects : LinkElement
{
    /// <summary>A property named ListObjectList that is a list of LinkElement objects.</summary>
    [JsonPropertyName("ListObjectList")]
    public List<LinkElement>? ListObjectList { get; set; }

}
