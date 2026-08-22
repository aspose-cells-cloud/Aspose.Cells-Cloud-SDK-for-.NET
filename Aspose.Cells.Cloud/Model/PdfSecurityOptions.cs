using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PdfSecurityOptions model.</summary>
public class PdfSecurityOptions
{
    /// <summary>Gets or sets the AnnotationsPermission.</summary>
    [JsonPropertyName("AnnotationsPermission")]
    public bool? AnnotationsPermission { get; set; }

    /// <summary>Gets or sets the AssembleDocumentPermission.</summary>
    [JsonPropertyName("AssembleDocumentPermission")]
    public bool? AssembleDocumentPermission { get; set; }

    /// <summary>Gets or sets the ExtractContentPermission.</summary>
    [JsonPropertyName("ExtractContentPermission")]
    public bool? ExtractContentPermission { get; set; }

    /// <summary>Gets or sets the FillFormsPermission.</summary>
    [JsonPropertyName("FillFormsPermission")]
    public bool? FillFormsPermission { get; set; }

    /// <summary>Gets or sets the FullQualityPrintPermission.</summary>
    [JsonPropertyName("FullQualityPrintPermission")]
    public bool? FullQualityPrintPermission { get; set; }

    /// <summary>Gets or sets the ModifyDocumentPermission.</summary>
    [JsonPropertyName("ModifyDocumentPermission")]
    public bool? ModifyDocumentPermission { get; set; }

    /// <summary>Gets or sets the OwnerPassword.</summary>
    [JsonPropertyName("OwnerPassword")]
    public string? OwnerPassword { get; set; }

    /// <summary>Gets or sets the PrintPermission.</summary>
    [JsonPropertyName("PrintPermission")]
    public bool? PrintPermission { get; set; }

    /// <summary>Gets or sets the UserPassword.</summary>
    [JsonPropertyName("UserPassword")]
    public string? UserPassword { get; set; }

}
