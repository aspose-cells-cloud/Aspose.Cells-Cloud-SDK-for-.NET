using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Cells Response.</summary>
public class CellsResponse : CellsCloudResponse
{
    /// <summary>Property Summary: The class has a property called "Cells" which is annotated with the [XmlElement("cells")] attribute.</summary>
    [JsonPropertyName("Cells")]
    public Cells? Cells { get; set; }

}
