using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CellsCloudPublicKey model.</summary>
public class CellsCloudPublicKey
{
    /// <summary>Gets or sets the Exponent.</summary>
    [JsonPropertyName("Exponent")]
    public string? Exponent { get; set; }

    /// <summary>Gets or sets the Modulus.</summary>
    [JsonPropertyName("Modulus")]
    public string? Modulus { get; set; }

}
