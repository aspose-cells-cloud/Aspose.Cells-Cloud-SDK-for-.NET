using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the Import2DimensionDoubleArrayOption model.</summary>
public class Import2DimensionDoubleArrayOption : ImportOption
{
    /// <summary>The class has a property named "FirstRow" of type integer with get and set accessors.</summary>
    [JsonPropertyName("FirstRow")]
    public int? FirstRow { get; set; }

    /// <summary>Gets or sets the FirstColumn.</summary>
    [JsonPropertyName("FirstColumn")]
    public int? FirstColumn { get; set; }

    /// <summary>Gets or sets the Data.</summary>
    [JsonPropertyName("Data")]
    public List<double>? Data { get; set; }

}
