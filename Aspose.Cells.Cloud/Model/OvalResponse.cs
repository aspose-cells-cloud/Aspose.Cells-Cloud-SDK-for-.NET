using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Oval Response.</summary>
public class OvalResponse : CellsCloudResponse
{
    /// <summary>The class has a public property called "Shape" of type "Oval" with both get and set accessors.</summary>
    [JsonPropertyName("Shape")]
    public Oval? Shape { get; set; }

}
