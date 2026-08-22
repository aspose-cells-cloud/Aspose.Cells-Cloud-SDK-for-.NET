using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the GroupBox Response.</summary>
public class GroupBoxResponse : CellsCloudResponse
{
    /// <summary>The class has a property named "Shape" of type GroupBox that can be accessed and modified.</summary>
    [JsonPropertyName("Shape")]
    public GroupBox? Shape { get; set; }

}
