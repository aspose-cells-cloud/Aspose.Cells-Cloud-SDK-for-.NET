using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the HorizontalPageBreaks Response.</summary>
public class HorizontalPageBreaksResponse : CellsCloudResponse
{
    /// <summary>The property "HorizontalPageBreaks" allows getting and setting horizontal page breaks for the class.</summary>
    [JsonPropertyName("HorizontalPageBreaks")]
    public HorizontalPageBreaks? HorizontalPageBreaks { get; set; }

}
