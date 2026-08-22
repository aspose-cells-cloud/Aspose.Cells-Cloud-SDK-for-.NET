using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates import xml data request</summary>
public class ImportJsonRequest
{
    /// <summary>Json file source</summary>
    [JsonPropertyName("JsonFileSource")]
    public DataSource? JsonFileSource { get; set; }

    /// <summary>Import position description.</summary>
    [JsonPropertyName("ImportPosition")]
    public ImportPosition? ImportPosition { get; set; }

    /// <summary>Base64String default is null</summary>
    [JsonPropertyName("JsonContent")]
    public string? JsonContent { get; set; }

}
