using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CellsCloudFileInfoResponse model.</summary>
public class CellsCloudFileInfoResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the FileInfo.</summary>
    [JsonPropertyName("FileInfo")]
    public CellsCloudFileInfo? FileInfo { get; set; }

}
