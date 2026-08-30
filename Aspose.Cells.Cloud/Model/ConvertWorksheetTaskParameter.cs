using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents convert worksheet task parameter.</summary>
public class ConvertWorksheetTaskParameter : TaskParameter
{
    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents data source of task object.</summary>
    [JsonPropertyName("Workbook")]
    public FileSource? Workbook { get; set; }

    /// <summary>Gets or sets the Sheet.</summary>
    [JsonPropertyName("Sheet")]
    public string? Sheet { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("TargetDataSource")]
    public DataSource? TargetDataSource { get; set; }

    /// <summary>Represents destination data source.</summary>
    [JsonPropertyName("Target")]
    public FileSource? Target { get; set; }

    /// <summary>Represents destination data format.</summary>
    [JsonPropertyName("Format")]
    public string? Format { get; set; }

    /// <summary>Represents converted data area.</summary>
    [JsonPropertyName("Area")]
    public string? Area { get; set; }

    /// <summary>Represents converted page index.</summary>
    [JsonPropertyName("PageIndex")]
    public int? PageIndex { get; set; }

    /// <summary>Represents vertical resolution.</summary>
    [JsonPropertyName("VerticalResolution")]
    public int? VerticalResolution { get; set; }

    /// <summary>Represents horizontal resolution.</summary>
    [JsonPropertyName("HorizontalResolution")]
    public int? HorizontalResolution { get; set; }

}
