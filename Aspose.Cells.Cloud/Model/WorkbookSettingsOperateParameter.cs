using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents workbook setting operate parameter.</summary>
public class WorkbookSettingsOperateParameter : OperateParameter
{
    /// <summary>Represents workbook setting.</summary>
    [JsonPropertyName("WorkbookSettings")]
    public WorkbookSettings? WorkbookSettings { get; set; }

}
