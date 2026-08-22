using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm happy to help! Please provide me with the features you would like me to summarize for the class.</summary>
public class CustomParserConfig
{
    /// <summary>Point Column</summary>
    [JsonPropertyName("ColumnIndex")]
    public int? ColumnIndex { get; set; }

    /// <summary>data parser method.</summary>
    [JsonPropertyName("ParseMethod")]
    public string? ParseMethod { get; set; }

    /// <summary>A property that allows storing and retrieving custom styling information for an object.</summary>
    [JsonPropertyName("CustomStyle")]
    public string? CustomStyle { get; set; }

}
