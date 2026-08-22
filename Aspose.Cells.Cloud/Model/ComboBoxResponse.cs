using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ComboBox Response.</summary>
public class ComboBoxResponse : CellsCloudResponse
{
    /// <summary>A public property of type ComboBox named Shape with get and set accessors.</summary>
    [JsonPropertyName("Shape")]
    public ComboBox? Shape { get; set; }

}
