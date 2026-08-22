using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates pivot table field request</summary>
public class PivotTableFieldRequest
{
    /// <summary>Intdex array.</summary>
    [JsonPropertyName("Data")]
    public List<int>? Data { get; set; }

}
