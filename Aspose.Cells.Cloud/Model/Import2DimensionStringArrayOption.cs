using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>I'm eager to assist you! Please provide me with the features you would like me to summarize into one sentence for your class summary.</summary>
public class Import2DimensionStringArrayOption : ImportOption
{
    /// <summary>This class has a property called FirstRow of type integer with a public getter and setter.</summary>
    [JsonPropertyName("FirstRow")]
    public int? FirstRow { get; set; }

    /// <summary>Gets or sets the FirstColumn.</summary>
    [JsonPropertyName("FirstColumn")]
    public int? FirstColumn { get; set; }

    /// <summary>Gets or sets the Data.</summary>
    [JsonPropertyName("Data")]
    public List<string>? Data { get; set; }

}
