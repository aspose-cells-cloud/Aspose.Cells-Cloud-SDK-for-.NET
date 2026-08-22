using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents list object operate parameter.</summary>
public class ListObjectOperateParameter : OperateParameter
{
    /// <summary>Represents list object of operate object.</summary>
    [JsonPropertyName("ListObject")]
    public ListObject? ListObject { get; set; }

}
