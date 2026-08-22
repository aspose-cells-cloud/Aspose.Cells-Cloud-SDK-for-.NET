using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Legend Response.</summary>
public class LegendResponse : CellsCloudResponse
{
    /// <summary>This class has a public property called "Legend" of type "Legend" which has both a getter and a setter.</summary>
    [JsonPropertyName("Legend")]
    public Legend? Legend { get; set; }

}
