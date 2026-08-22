using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates protect workbook request</summary>
public class ProtectWorkbookRequest
{
    /// <summary>Indicates aways open read-only.</summary>
    [JsonPropertyName("AwaysOpenReadOnly")]
    public bool? AwaysOpenReadOnly { get; set; }

    /// <summary>Indicates encrypt with password.</summary>
    [JsonPropertyName("EncryptWithPassword")]
    public string? EncryptWithPassword { get; set; }

    /// <summary>Represents the various types of protection options available for a worksheet.</summary>
    [JsonPropertyName("ProtectCurrentSheet")]
    public Protection? ProtectCurrentSheet { get; set; }

    /// <summary>Represents the various types of protection options available for all worksheets.</summary>
    [JsonPropertyName("ProtectAllSheets")]
    public Protection? ProtectAllSheets { get; set; }

    /// <summary>Indicates protect workbook structure. All, Contents, Objects, Scenarios, Structure, Windows, and None.</summary>
    [JsonPropertyName("ProtectWorkbookStructure")]
    public string? ProtectWorkbookStructure { get; set; }

    /// <summary>Indicates signature in file.</summary>
    [JsonPropertyName("DigitalSignature")]
    public DigitalSignature? DigitalSignature { get; set; }

    /// <summary>Indicates mark as final.</summary>
    [JsonPropertyName("MarkAsFinal")]
    public bool? MarkAsFinal { get; set; }

}
