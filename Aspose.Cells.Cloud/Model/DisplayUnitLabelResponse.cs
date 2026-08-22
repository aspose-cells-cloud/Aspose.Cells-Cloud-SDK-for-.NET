using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the DisplayUnitLabel Response.</summary>
public class DisplayUnitLabelResponse : CellsCloudResponse
{
    /// <summary>This property allows access to the display unit label for the class.</summary>
    [JsonPropertyName("DisplayUnitLabel")]
    public DisplayUnitLabel? DisplayUnitLabel { get; set; }

}
