using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a chart, which is a chart created based on data analysis of a table.</summary>
public class DiscoverChart
{
    /// <summary>Represents chart name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Represents worksheet name which is where the chart is located.</summary>
    [JsonPropertyName("SheetName")]
    public string? SheetName { get; set; }

    /// <summary>Represents chart title.</summary>
    [JsonPropertyName("Title")]
    public string? Title { get; set; }

    /// <summary>Represents chart type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Represents chart data range.</summary>
    [JsonPropertyName("DataRange")]
    public string? DataRange { get; set; }

    /// <summary>Represents chart thumbnail. Base64String</summary>
    [JsonPropertyName("Thumbnail")]
    public string? Thumbnail { get; set; }

}
