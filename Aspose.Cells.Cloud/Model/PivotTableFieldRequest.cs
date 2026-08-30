using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates pivot table field request</summary>
public class PivotTableFieldRequest
{
    /// <summary>Gets or sets the Data.</summary>
    [JsonPropertyName("Data")]
    public List<int>? Data { get; set; }

}
