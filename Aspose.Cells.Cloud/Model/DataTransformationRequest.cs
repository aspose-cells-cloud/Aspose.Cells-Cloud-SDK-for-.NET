using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Data Transformation Request</summary>
public class DataTransformationRequest
{
    /// <summary>Indicates the source of the mount data.</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Indicates the source of the mount data.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Indicates load data.</summary>
    [JsonPropertyName("LoadData")]
    public LoadData? LoadData { get; set; }

    /// <summary>Indicates applied step list.</summary>
    [JsonPropertyName("AppliedSteps")]
    public List<AppliedStep>? AppliedSteps { get; set; }

    /// <summary>This class has a property named "Region" of type string with both a getter and a setter.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

    /// <summary>Indicates output format</summary>
    [JsonPropertyName("OutFormat")]
    public string? OutFormat { get; set; }

}
