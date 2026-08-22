using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the VerticalPageBreak Response.</summary>
public class VerticalPageBreakResponse : CellsCloudResponse
{
    /// <summary>The class has a property that represents a vertical page break.</summary>
    [JsonPropertyName("VerticalPageBreak")]
    public VerticalPageBreak? VerticalPageBreak { get; set; }

}
