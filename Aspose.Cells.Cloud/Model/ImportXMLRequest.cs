using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates import xml data request</summary>
public class ImportXMLRequest
{
    /// <summary>XML file source</summary>
    [JsonPropertyName("XMLFileSource")]
    public DataSource? XMLFileSource { get; set; }

    /// <summary>Import position description.</summary>
    [JsonPropertyName("ImportPosition")]
    public ImportPosition? ImportPosition { get; set; }

    /// <summary>Base64String default is null</summary>
    [JsonPropertyName("XMLContent")]
    public string? XMLContent { get; set; }

}
