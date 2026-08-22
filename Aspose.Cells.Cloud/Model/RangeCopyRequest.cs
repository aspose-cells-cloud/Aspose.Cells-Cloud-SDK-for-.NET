using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates range copy request</summary>
public class RangeCopyRequest
{
    /// <summary>copydata, copystyle, copyto, copyvalue.</summary>
    [JsonPropertyName("Operate")]
    public string? Operate { get; set; }

    /// <summary>Source range.</summary>
    [JsonPropertyName("Source")]
    public Range? Source { get; set; }

    /// <summary>Target range.</summary>
    [JsonPropertyName("Target")]
    public Range? Target { get; set; }

    /// <summary>Gets or sets the TargetWorkbook.</summary>
    [JsonPropertyName("TargetWorkbook")]
    public string? TargetWorkbook { get; set; }

    /// <summary>Represents the paste special options.</summary>
    [JsonPropertyName("PasteOptions")]
    public PasteOptions? PasteOptions { get; set; }

}
