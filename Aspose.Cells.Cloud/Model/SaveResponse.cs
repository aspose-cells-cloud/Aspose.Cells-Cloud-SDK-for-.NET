using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SaveResponse model.</summary>
public class SaveResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the SaveResult.</summary>
    [JsonPropertyName("SaveResult")]
    public SaveResult? SaveResult { get; set; }

}
