using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents autofiltering for the specified worksheet.</summary>
public class AutoFilter : LinkElement
{
    /// <summary>Gets the collection of the filter columns.</summary>
    [JsonPropertyName("FilterColumns")]
    public List<FilterColumn>? FilterColumns { get; set; }

    /// <summary>Represents the range to which the specified AutoFilter applies.</summary>
    [JsonPropertyName("Range")]
    public string? Range { get; set; }

    /// <summary>Gets the data sorter.</summary>
    [JsonPropertyName("Sorter")]
    public DataSorter? Sorter { get; set; }

    /// <summary>Indicates whether the AutoFilter button for this column is visible.</summary>
    [JsonPropertyName("ShowFilterButton")]
    public bool? ShowFilterButton { get; set; }

}
