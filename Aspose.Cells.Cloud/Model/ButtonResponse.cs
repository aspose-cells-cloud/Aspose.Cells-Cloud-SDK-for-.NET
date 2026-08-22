using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Button Response.</summary>
public class ButtonResponse : CellsCloudResponse
{
    /// <summary>The class has a property named "Shape" of type Button that can be both read and written.</summary>
    [JsonPropertyName("Shape")]
    public Button? Shape { get; set; }

}
