using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents data source.</summary>
public class DataSource
{
    /// <summary>Represents data source type.</summary>
    [JsonPropertyName("DataSourceType")]
    public string? DataSourceType { get; set; }

    /// <summary>Represents data path.</summary>
    [JsonPropertyName("DataPath")]
    public string? DataPath { get; set; }

}
