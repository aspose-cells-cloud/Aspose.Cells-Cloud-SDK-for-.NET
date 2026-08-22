using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ConditionalFormattings Response.</summary>
public class ConditionalFormattingsResponse : CellsCloudResponse
{
    /// <summary>A property named ConditionalFormattings of type ConditionalFormattings is defined with both getter and setter methods in the class.</summary>
    [JsonPropertyName("ConditionalFormattings")]
    public ConditionalFormattings? ConditionalFormattings { get; set; }

}
