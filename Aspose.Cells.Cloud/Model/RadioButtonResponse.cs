using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the RadioButton Response.</summary>
public class RadioButtonResponse : CellsCloudResponse
{
    /// <summary>This class has a public property named "Shape" of type RadioButton with both getter and setter.</summary>
    [JsonPropertyName("Shape")]
    public RadioButton? Shape { get; set; }

}
