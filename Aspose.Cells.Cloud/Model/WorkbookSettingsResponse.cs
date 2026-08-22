using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the WorkbookSettings Response.</summary>
public class WorkbookSettingsResponse : CellsCloudResponse
{
    /// <summary>The class has a public property called "settings" of type WorkbookSettings that can be accessed and modified.</summary>
    [JsonPropertyName("settings")]
    public WorkbookSettings? Settings { get; set; }

}
