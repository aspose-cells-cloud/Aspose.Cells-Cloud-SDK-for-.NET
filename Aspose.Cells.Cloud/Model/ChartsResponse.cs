using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Charts Response.</summary>
public class ChartsResponse : CellsCloudResponse
{
    /// <summary>Property Summary: Includes an XML element named "charts" that contains a property of type Charts.Charts.</summary>
    [JsonPropertyName("Charts")]
    public Charts? Charts { get; set; }

}
