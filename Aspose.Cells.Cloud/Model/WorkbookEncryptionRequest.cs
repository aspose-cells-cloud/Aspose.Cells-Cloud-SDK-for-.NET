using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Used by workbook encryption/decryption requests.</summary>
public class WorkbookEncryptionRequest
{
    /// <summary>Workbook encription type.</summary>
    [JsonPropertyName("EncryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Encription key length.</summary>
    [JsonPropertyName("KeyLength")]
    public int? KeyLength { get; set; }

    /// <summary>Encription password.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

}
