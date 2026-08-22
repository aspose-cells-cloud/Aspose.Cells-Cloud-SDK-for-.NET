using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Used by workbook protection requests.</summary>
public class WorkbookProtectionRequest
{
    /// <summary>Protection type. Can be ALL, CONTENTS, NONE, OBJECTS, SCENARIOS, STRUCTURE, WINDOWS</summary>
    [JsonPropertyName("ProtectionType")]
    public string? ProtectionType { get; set; }

    /// <summary>Encription password.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

}
