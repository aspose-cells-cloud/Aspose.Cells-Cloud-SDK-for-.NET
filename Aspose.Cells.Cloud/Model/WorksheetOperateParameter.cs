using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents worksheet operate parameter.</summary>
public class WorksheetOperateParameter : OperateParameter
{
    /// <summary>Represents worksheet name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Represents worksheet type.</summary>
    [JsonPropertyName("SheetType")]
    public string? SheetType { get; set; }

    /// <summary>rename worksheet name</summary>
    [JsonPropertyName("NewName")]
    public string? NewName { get; set; }

    /// <summary>Represents move position.</summary>
    [JsonPropertyName("MovingRequest")]
    public WorksheetMovingRequest? MovingRequest { get; set; }

}
