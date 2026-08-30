using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ImportCSVDataOption model.</summary>
public class ImportCSVDataOption : ImportOption
{
    /// <summary>A property named SeparatorString of type string that can be accessed and modified publicly.</summary>
    [JsonPropertyName("SeparatorString")]
    public string? SeparatorString { get; set; }

    /// <summary>Gets or sets the ConvertNumericData.</summary>
    [JsonPropertyName("ConvertNumericData")]
    public bool? ConvertNumericData { get; set; }

    /// <summary>Gets or sets the FirstRow.</summary>
    [JsonPropertyName("FirstRow")]
    public int? FirstRow { get; set; }

    /// <summary>Gets or sets the FirstColumn.</summary>
    [JsonPropertyName("FirstColumn")]
    public int? FirstColumn { get; set; }

    /// <summary>Gets or sets the SourceFile.</summary>
    [JsonPropertyName("SourceFile")]
    public string? SourceFile { get; set; }

    /// <summary>Gets or sets the CustomParsers.</summary>
    [JsonPropertyName("CustomParsers")]
    public List<CustomParserConfig>? CustomParsers { get; set; }

}
