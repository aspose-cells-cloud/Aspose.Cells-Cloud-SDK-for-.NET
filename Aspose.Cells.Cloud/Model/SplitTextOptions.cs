using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Appliance features: 1. Automatic defrost system 2. Energy-efficient LED lighting 3. Adjustable glass shelves 4. Ice and water dispenser with filtration system</summary>
public class SplitTextOptions : BaseOperateOptions
{
    /// <summary>Represents data source.  There are three types of data, they are CloudFileSystem, RequestFiles, HttpUri.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Represents file information. Include of filename, filesize, and file content(base64String).</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the Worksheet.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

    /// <summary>Gets or sets the Range.</summary>
    [JsonPropertyName("Range")]
    public string? Range { get; set; }

    /// <summary>Gets or sets the SplitDelimitersType.</summary>
    [JsonPropertyName("SplitDelimitersType")]
    public string? SplitDelimitersType { get; set; }

    /// <summary>Gets or sets the CustomDelimiter.</summary>
    [JsonPropertyName("CustomDelimiter")]
    public string? CustomDelimiter { get; set; }

    /// <summary>Gets or sets the KeepDelimitersInResultingCells.</summary>
    [JsonPropertyName("KeepDelimitersInResultingCells")]
    public bool? KeepDelimitersInResultingCells { get; set; }

    /// <summary>Gets or sets the KeepDelimitersPosition.</summary>
    [JsonPropertyName("KeepDelimitersPosition")]
    public string? KeepDelimitersPosition { get; set; }

    /// <summary>Gets or sets the HowToSplit.</summary>
    [JsonPropertyName("HowToSplit")]
    public string? HowToSplit { get; set; }

}
