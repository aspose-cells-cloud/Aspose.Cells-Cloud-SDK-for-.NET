using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm here to help! Please provide the features you'd like me to summarize.</summary>
public class Import2DimensionIntArrayOption : ImportOption
{
    /// <summary>This property allows getting and setting the value of the first row in a class.</summary>
    [JsonPropertyName("FirstRow")]
    public int? FirstRow { get; set; }

    /// <summary>Gets or sets the FirstColumn.</summary>
    [JsonPropertyName("FirstColumn")]
    public int? FirstColumn { get; set; }

    /// <summary>Gets or sets the Data.</summary>
    [JsonPropertyName("Data")]
    public List<int>? Data { get; set; }

}
