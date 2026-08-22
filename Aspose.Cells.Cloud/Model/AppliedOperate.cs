using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>A data operation that is used to obtain a query of data.</summary>
public abstract class AppliedOperate
{
    /// <summary>Property summary: Utilizes a custom JSON converter to serialize and deserialize an enum property.</summary>
    [JsonPropertyName("AppliedOperateType")]
    public string? AppliedOperateType { get; set; }

}
