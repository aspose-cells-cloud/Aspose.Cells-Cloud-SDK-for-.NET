using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents import data task parameter.</summary>
public class ImportDataTaskParameter : TaskParameter
{
    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("Workbook")]
    public FileSource? Workbook { get; set; }

    /// <summary>Represents import option.</summary>
    [JsonPropertyName("ImportOption")]
    public ImportOption? ImportOption { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("TargetDataSource")]
    public DataSource? TargetDataSource { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("DestinationWorkbook")]
    public FileSource? DestinationWorkbook { get; set; }

}
