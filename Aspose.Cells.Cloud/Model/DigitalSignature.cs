using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Signature in file.</summary>
public class DigitalSignature
{
    /// <summary>The purpose to signature.</summary>
    [JsonPropertyName("Comments")]
    public string? Comments { get; set; }

    /// <summary>The time when the document was signed.</summary>
    [JsonPropertyName("SignTime")]
    public string? SignTime { get; set; }

    /// <summary>Specifies a GUID which can be cross-referenced with the GUID of the signature line stored in the document content. Default value is Empty (all zeroes) Guid.</summary>
    [JsonPropertyName("Id")]
    public string? Id { get; set; }

    /// <summary>Specifies the text of actual signature in the digital signature. Default value is Empty.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

    /// <summary>Specifies an image for the digital signature. Default value is null.</summary>
    [JsonPropertyName("Image")]
    public byte[]? Image { get; set; }

    /// <summary>Specifies the class ID of the signature provider. Default value is Empty (all zeroes) Guid.</summary>
    [JsonPropertyName("ProviderId")]
    public string? ProviderId { get; set; }

    /// <summary>If this digital signature is valid and the document has not been tampered with, this value will be true.</summary>
    [JsonPropertyName("IsValid")]
    public bool? IsValid { get; set; }

    /// <summary>XAdES type. Default value is None(XAdES is off).</summary>
    [JsonPropertyName("XAdESType")]
    public string? XAdESType { get; set; }

}
