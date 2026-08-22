using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents smart marker task parameter.</summary>
public class SmartMarkerTaskParameter : TaskParameter
{
    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("SourceWorkbook")]
    public FileSource? SourceWorkbook { get; set; }

    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("DestinationWorkbook")]
    public FileSource? DestinationWorkbook { get; set; }

    /// <summary>Represents xml file.</summary>
    [JsonPropertyName("xmlFile")]
    public FileSource? XmlFile { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("TargetDataSource")]
    public DataSource? TargetDataSource { get; set; }

    /// <summary>Represents xml file.</summary>
    [JsonPropertyName("XMLFileDataSource")]
    public DataSource? XMLFileDataSource { get; set; }

}
