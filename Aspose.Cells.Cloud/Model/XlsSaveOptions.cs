using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the XlsSaveOptions model.</summary>
public class XlsSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the MatchColor.</summary>
    [JsonPropertyName("MatchColor")]
    public bool? MatchColor { get; set; }

    /// <summary>Gets or sets the WpsCompatibility.</summary>
    [JsonPropertyName("WpsCompatibility")]
    public bool? WpsCompatibility { get; set; }

}
