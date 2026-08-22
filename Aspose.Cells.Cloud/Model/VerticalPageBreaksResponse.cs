using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the VerticalPageBreaks Response.</summary>
public class VerticalPageBreaksResponse : CellsCloudResponse
{
    /// <summary>This class has a property named VerticalPageBreaks of type VerticalPageBreaks that can be both read from and written to.</summary>
    [JsonPropertyName("VerticalPageBreaks")]
    public VerticalPageBreaks? VerticalPageBreaks { get; set; }

}
