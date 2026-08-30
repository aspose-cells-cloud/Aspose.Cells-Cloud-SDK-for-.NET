using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the DataQuery model.</summary>
public class DataQuery
{
    /// <summary>Define a name for data query. Unique identification.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>The specific data object type. When the value is File, DataItem is invalid.</summary>
    [JsonPropertyName("DataSourceDataType")]
    public string? DataSourceDataType { get; set; }

    /// <summary>Indicates the source of the mount data.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>When data souce is request files, FileInfo store the contents of the file.</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>The specific data object type and name.</summary>
    [JsonPropertyName("DataItem")]
    public DataItem? DataItem { get; set; }

}
