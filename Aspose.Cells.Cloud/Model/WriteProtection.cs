using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Specifies write protection settings for a workbook.</summary>
public class WriteProtection
{
    /// <summary>Gets and sets the author.</summary>
    [JsonPropertyName("Author")]
    public string? Author { get; set; }

    /// <summary>Indicates if the Read Only Recommended option is selected.</summary>
    [JsonPropertyName("RecommendReadOnly")]
    public bool? RecommendReadOnly { get; set; }

    /// <summary>Indicates whether this workbook is write protected.</summary>
    [JsonPropertyName("IsWriteProtected")]
    public bool? IsWriteProtected { get; set; }

    /// <summary>Sets the protected password to modify the file.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

}
