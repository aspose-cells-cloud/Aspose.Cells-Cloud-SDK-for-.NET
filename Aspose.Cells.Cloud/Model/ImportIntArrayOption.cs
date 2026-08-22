using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm here to help! Just provide me with the features you'd like to summarize.</summary>
public class ImportIntArrayOption : ImportOption
{
    /// <summary>This class has a public property named "FirstRow" of type integer with both get and set accessors.</summary>
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
    public List<int>? Data { get; set; }

}
