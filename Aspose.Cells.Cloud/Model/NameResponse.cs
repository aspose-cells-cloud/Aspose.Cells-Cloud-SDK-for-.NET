using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Name Response.</summary>
public class NameResponse : CellsCloudResponse
{
    /// <summary>A public property that allows getting and setting a value of type "Name".</summary>
    [JsonPropertyName("Name")]
    public Name? Name { get; set; }

}
