using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Series Response.</summary>
public class SeriesResponse : CellsCloudResponse
{
    /// <summary>A public property named "Series" of type Series with both getter and setter methods.</summary>
    [JsonPropertyName("Series")]
    public Series? Series { get; set; }

}
