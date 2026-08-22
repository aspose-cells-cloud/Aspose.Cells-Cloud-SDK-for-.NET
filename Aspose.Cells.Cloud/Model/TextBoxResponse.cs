using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the TextBox Response.</summary>
public class TextBoxResponse : CellsCloudResponse
{
    /// <summary>A public property named "Shape" of type TextBox is defined with both get and set accessors.</summary>
    [JsonPropertyName("Shape")]
    public TextBox? Shape { get; set; }

}
