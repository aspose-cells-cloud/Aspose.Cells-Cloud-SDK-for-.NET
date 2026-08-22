using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ListBox Response.</summary>
public class ListBoxResponse : CellsCloudResponse
{
    /// <summary>A property "Shape" of type ListBox with read and write access is available for the class.</summary>
    [JsonPropertyName("Shape")]
    public ListBox? Shape { get; set; }

}
