using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Style Response.</summary>
public class StyleResponse : CellsCloudResponse
{
    /// <summary>A property named "Style" of type "Style" is defined with both getter and setter methods.</summary>
    [JsonPropertyName("Style")]
    public Style? Style { get; set; }

}
