using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CustomParserConfig model.</summary>
public class CustomParserConfig
{
    /// <summary>Gets or sets the ColumnIndex.</summary>
    [JsonPropertyName("ColumnIndex")]
    public int? ColumnIndex { get; set; }

    /// <summary>data parser method.</summary>
    [JsonPropertyName("ParseMethod")]
    public string? ParseMethod { get; set; }

    /// <summary>A property that allows storing and retrieving custom styling information for an object.</summary>
    [JsonPropertyName("CustomStyle")]
    public string? CustomStyle { get; set; }

}
