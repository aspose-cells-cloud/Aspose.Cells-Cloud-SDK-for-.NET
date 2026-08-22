using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the HorizontalPageBreak Response.</summary>
public class HorizontalPageBreakResponse : CellsCloudResponse
{
    /// <summary>HorizontalPageBreak is a property of the class that represents a horizontal page break.</summary>
    [JsonPropertyName("HorizontalPageBreak")]
    public HorizontalPageBreak? HorizontalPageBreak { get; set; }

}
