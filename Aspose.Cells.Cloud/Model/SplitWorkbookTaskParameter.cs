using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents split workbook task parameter.</summary>
public class SplitWorkbookTaskParameter : TaskParameter
{
    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("Workbook")]
    public FileSource? Workbook { get; set; }

    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("DestinationFilePosition")]
    public FileSource? DestinationFilePosition { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("TargetDataSource")]
    public DataSource? TargetDataSource { get; set; }

    /// <summary>Represents destination data file format.</summary>
    [JsonPropertyName("DestinationFileFormat")]
    public string? DestinationFileFormat { get; set; }

    /// <summary>SheetName /NewGuid</summary>
    [JsonPropertyName("SplitNameRule")]
    public string? SplitNameRule { get; set; }

    /// <summary>When destination file format is image , vertical resolution can not be null.</summary>
    [JsonPropertyName("VerticalResolution")]
    public int? VerticalResolution { get; set; }

    /// <summary>When destination file format is image , horizontal resolution can not be null.</summary>
    [JsonPropertyName("HorizontalResolution")]
    public int? HorizontalResolution { get; set; }

}
