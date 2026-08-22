using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents data cleansing.</summary>
public class DataCleansing
{
    /// <summary>A property named "Ranges" of type IList Range with a default value of an empty List of Range objects.</summary>
    [JsonPropertyName("Ranges")]
    public List<Range>? Ranges { get; set; }

    /// <summary>Represents whether the data needs to be populated.</summary>
    [JsonPropertyName("NeedFillData")]
    public bool? NeedFillData { get; set; }

    /// <summary>Represents data fill.</summary>
    [JsonPropertyName("DataFill")]
    public DataFill? DataFill { get; set; }

}
