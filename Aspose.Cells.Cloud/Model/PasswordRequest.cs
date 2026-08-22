using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Used for password data transfer.</summary>
public class PasswordRequest
{
    /// <summary>Password.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

}
