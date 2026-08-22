using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SpecifyWordsCountOptions model.</summary>
public class SpecifyWordsCountOptions
{
    /// <summary>Gets or sets the DataSource.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Gets or sets the FileInfo.</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the SearchWord.</summary>
    [JsonPropertyName("SearchWord")]
    public string? SearchWord { get; set; }

}
