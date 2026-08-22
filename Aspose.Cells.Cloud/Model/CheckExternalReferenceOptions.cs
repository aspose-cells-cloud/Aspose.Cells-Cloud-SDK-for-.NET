using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CheckExternalReferenceOptions model.</summary>
public class CheckExternalReferenceOptions
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

    /// <summary>Gets or sets the Ranged_Table.</summary>
    [JsonPropertyName("Ranged_Table")]
    public string? Ranged_Table { get; set; }

    /// <summary>Gets or sets the ChartIndex.</summary>
    [JsonPropertyName("ChartIndex")]
    public int? ChartIndex { get; set; }

}
