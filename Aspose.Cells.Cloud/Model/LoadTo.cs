using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>A description of the location to which the data is mounted.</summary>
public class LoadTo
{
    /// <summary>The worksheet name.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

    /// <summary>The begin row index of worksheet.</summary>
    [JsonPropertyName("beginRowIndex")]
    public int? BeginRowIndex { get; set; }

    /// <summary>The begin column index of worksheet.</summary>
    [JsonPropertyName("beginColumnIndex")]
    public int? BeginColumnIndex { get; set; }

}
