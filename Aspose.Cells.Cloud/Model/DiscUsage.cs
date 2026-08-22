using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Class for disc space information.</summary>
public class DiscUsage
{
    /// <summary>Application used disc space.</summary>
    [JsonPropertyName("UsedSize")]
    public long? UsedSize { get; set; }

    /// <summary>Total disc space.</summary>
    [JsonPropertyName("TotalSize")]
    public long? TotalSize { get; set; }

}
