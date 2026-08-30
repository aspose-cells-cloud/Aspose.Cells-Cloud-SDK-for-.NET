using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates range copy request</summary>
public class RangeCopyRequest
{
    /// <summary>copydata, copystyle, copyto, copyvalue.</summary>
    [JsonPropertyName("Operate")]
    public string? Operate { get; set; }

    /// <summary>Gets or sets the Source.</summary>
    [JsonPropertyName("Source")]
    public Range? Source { get; set; }

    /// <summary>Gets or sets the Target.</summary>
    [JsonPropertyName("Target")]
    public Range? Target { get; set; }

    /// <summary>Gets or sets the TargetWorkbook.</summary>
    [JsonPropertyName("TargetWorkbook")]
    public string? TargetWorkbook { get; set; }

    /// <summary>Represents the paste special options.</summary>
    [JsonPropertyName("PasteOptions")]
    public PasteOptions? PasteOptions { get; set; }

}
