using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the DataOutputLocation model.</summary>
public class DataOutputLocation
{
    /// <summary>Gets or sets the DataSource.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Gets or sets the FileInfo.</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the Worksheet.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

    /// <summary>Gets or sets the BeginRowIndex.</summary>
    [JsonPropertyName("BeginRowIndex")]
    public int? BeginRowIndex { get; set; }

    /// <summary>Gets or sets the BeginColumnIndex.</summary>
    [JsonPropertyName("BeginColumnIndex")]
    public int? BeginColumnIndex { get; set; }

}
