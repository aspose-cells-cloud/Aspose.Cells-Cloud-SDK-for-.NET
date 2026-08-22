using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Shapes Response.</summary>
public class ShapesResponse : CellsCloudResponse
{
    /// <summary>The class has a property called "Shapes" with XML serialization attribute "XmlElement" for specifying the element name in the XML representation.</summary>
    [JsonPropertyName("Shapes")]
    public Shapes? Shapes { get; set; }

}
