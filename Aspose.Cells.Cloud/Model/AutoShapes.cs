using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the AutoShapes model.</summary>
public class AutoShapes : LinkElement
{
    /// <summary>Property Summary: Contains a list of LinkElement objects identified by the XML element "autoshape".</summary>
    [JsonPropertyName("AutoShapeList")]
    public List<LinkElement>? AutoShapeList { get; set; }

}
