using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents convert task parameter.</summary>
public class ConvertTaskParameter : TaskParameter
{
    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("Workbook")]
    public FileSource? Workbook { get; set; }

    /// <summary>Represents destination file.</summary>
    [JsonPropertyName("DestinationFile")]
    public string? DestinationFile { get; set; }

    /// <summary>Represents Excel data region.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

    /// <summary>Represents save options.</summary>
    [JsonPropertyName("SaveOptions")]
    public SaveOptions? SaveOptions { get; set; }

}
