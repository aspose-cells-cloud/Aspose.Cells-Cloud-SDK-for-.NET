using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ScrollBar Response.</summary>
public class ScrollBarResponse : CellsCloudResponse
{
    /// <summary>The class has a public property named `Shape` of type `ScrollBar` that can be both read and written.</summary>
    [JsonPropertyName("Shape")]
    public ScrollBar? Shape { get; set; }

}
