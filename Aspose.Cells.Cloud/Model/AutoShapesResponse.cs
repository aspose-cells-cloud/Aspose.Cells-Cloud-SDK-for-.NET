using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the AutoShapes Response.</summary>
public class AutoShapesResponse : CellsCloudResponse
{
    /// <summary>The class has a property named "AutoShapes" decorated with the XmlElement attribute "shapes".</summary>
    [JsonPropertyName("AutoShapes")]
    public AutoShapes? AutoShapes { get; set; }

}
