using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Serieses Response.</summary>
public class SeriesesResponse : CellsCloudResponse
{
    /// <summary>A property named "Serieses" of type "SeriesItems" is defined in the class with both getter and setter access.</summary>
    [JsonPropertyName("Serieses")]
    public SeriesItems? Serieses { get; set; }

}
