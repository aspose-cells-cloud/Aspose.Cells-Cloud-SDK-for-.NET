using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Label Response.</summary>
public class LabelResponse : CellsCloudResponse
{
    /// <summary>The property "Shape" is of type Label and has both a getter and a setter.</summary>
    [JsonPropertyName("Shape")]
    public Label? Shape { get; set; }

}
