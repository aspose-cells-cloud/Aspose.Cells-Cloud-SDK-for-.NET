using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the OdsSaveOptions model.</summary>
public class OdsSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the GeneratorType.</summary>
    [JsonPropertyName("GeneratorType")]
    public string? GeneratorType { get; set; }

    /// <summary>Gets or sets the OdfStrictVersion.</summary>
    [JsonPropertyName("OdfStrictVersion")]
    public string? OdfStrictVersion { get; set; }

    /// <summary>Gets or sets the IgnorePivotTables.</summary>
    [JsonPropertyName("IgnorePivotTables")]
    public bool? IgnorePivotTables { get; set; }

}
