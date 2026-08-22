using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CellsCloudPublicKeyResponse model.</summary>
public class CellsCloudPublicKeyResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the CellsCloudPublicKey.</summary>
    [JsonPropertyName("CellsCloudPublicKey")]
    public CellsCloudPublicKey? CellsCloudPublicKey { get; set; }

}
