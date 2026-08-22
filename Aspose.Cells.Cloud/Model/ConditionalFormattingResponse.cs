using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ConditionalFormatting Response.</summary>
public class ConditionalFormattingResponse : CellsCloudResponse
{
    /// <summary>This class has a property named ConditionalFormatting of type ConditionalFormatting that can be accessed and modified.</summary>
    [JsonPropertyName("ConditionalFormatting")]
    public ConditionalFormatting? ConditionalFormatting { get; set; }

}
