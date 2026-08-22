using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Sure, could you please provide me with the features you would like me to summarize?</summary>
public class MergedCells : LinkElement
{
    /// <summary>An integer property labeled as "count" and marked as an XML element in the class.</summary>
    [JsonPropertyName("Count")]
    public int? Count { get; set; }

    /// <summary>Gets or sets the MergedCellList.</summary>
    [JsonPropertyName("MergedCellList")]
    public List<LinkElement>? MergedCellList { get; set; }

}
