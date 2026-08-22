using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents operate object.</summary>
public class OperateObject
{
    /// <summary>Represents operate object type.</summary>
    [JsonPropertyName("OperateObjectType")]
    public string? OperateObjectType { get; set; }

    /// <summary>Represents position of operate object.</summary>
    [JsonPropertyName("Position")]
    public OperateObjectPosition? Position { get; set; }

}
