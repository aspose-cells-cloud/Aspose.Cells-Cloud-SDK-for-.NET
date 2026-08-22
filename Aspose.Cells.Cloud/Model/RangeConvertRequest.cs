using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates range copy request</summary>
public class RangeConvertRequest
{
    /// <summary>Source range.</summary>
    [JsonPropertyName("Source")]
    public Range? Source { get; set; }

    /// <summary>Target range.</summary>
    [JsonPropertyName("ImageType")]
    public string? ImageType { get; set; }

    /// <summary>Represents the paste special options.</summary>
    [JsonPropertyName("ImageOrPrintOptions")]
    public ImageOrPrintOptions? ImageOrPrintOptions { get; set; }

    /// <summary>Gets or sets the PageSetup.</summary>
    [JsonPropertyName("PageSetup")]
    public PageSetup? PageSetup { get; set; }

}
