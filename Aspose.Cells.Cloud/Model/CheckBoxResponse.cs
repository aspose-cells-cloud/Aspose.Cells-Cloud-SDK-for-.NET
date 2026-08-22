using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CheckBox Response.</summary>
public class CheckBoxResponse : CellsCloudResponse
{
    /// <summary>A public property named Shape of type CheckBox is defined with both get and set accessors.</summary>
    [JsonPropertyName("Shape")]
    public CheckBox? Shape { get; set; }

}
