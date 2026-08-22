using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm happy to help! Could you please provide me with the features you would like me to summarize for the class?</summary>
public class ImportStringArrayOption : ImportOption
{
    /// <summary>A property named "FirstRow" of type integer with both a getter and a setter is defined in the class.</summary>
    [JsonPropertyName("FirstRow")]
    public int? FirstRow { get; set; }

    /// <summary>Gets or sets the FirstColumn.</summary>
    [JsonPropertyName("FirstColumn")]
    public int? FirstColumn { get; set; }

    /// <summary>Gets or sets the IsVertical.</summary>
    [JsonPropertyName("IsVertical")]
    public bool? IsVertical { get; set; }

    /// <summary>Gets or sets the Data.</summary>
    [JsonPropertyName("Data")]
    public List<string>? Data { get; set; }

}
