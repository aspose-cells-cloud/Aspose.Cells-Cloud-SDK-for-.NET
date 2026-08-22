using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a pivot table, which is a pivot table created based on data analysis of a table.</summary>
public class DiscoverPivotTable
{
    /// <summary>Represents pivot table name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Represents pivot table title.</summary>
    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    /// <summary>Represents pivot table data range.</summary>
    [JsonPropertyName("DataRange")]
    public string? DataRange { get; set; }

    /// <summary>Represents row fields in a PivotTable report.</summary>
    [JsonPropertyName("PivotFieldRows")]
    public List<int>? PivotFieldRows { get; set; }

    /// <summary>Represents column fields in a PivotTable report.</summary>
    [JsonPropertyName("PivotFieldColumns")]
    public List<int>? PivotFieldColumns { get; set; }

    /// <summary>Represents data fields in a PivotTable report.</summary>
    [JsonPropertyName("PivotFieldData")]
    public List<int>? PivotFieldData { get; set; }

    /// <summary>Represents pivot table thumbnail. Base64String</summary>
    [JsonPropertyName("Thumbnail")]
    public string? Thumbnail { get; set; }

}
