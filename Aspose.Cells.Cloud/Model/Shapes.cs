using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents all the shape in a worksheet/chart.</summary>
public class Shapes : LinkElement
{
    /// <summary>A public property named "ShapeList" of type List LinkElement for storing a collection of link elements.</summary>
    [JsonPropertyName("ShapeList")]
    public List<LinkElement>? ShapeList { get; set; }

}
