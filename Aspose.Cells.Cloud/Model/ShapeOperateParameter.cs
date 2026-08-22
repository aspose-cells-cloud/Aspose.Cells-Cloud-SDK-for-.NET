using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents shape operate parameter.</summary>
public class ShapeOperateParameter : OperateParameter
{
    /// <summary>Represents shape object.</summary>
    [JsonPropertyName("Shape")]
    public Shape? Shape { get; set; }

}
