using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SaveOptions model.</summary>
public class SaveOptions
{
    /// <summary>Gets or sets the SaveFormat.</summary>
    [JsonPropertyName("SaveFormat")]
    public string? SaveFormat { get; set; }

    /// <summary>Gets or sets the CachedFileFolder.</summary>
    [JsonPropertyName("CachedFileFolder")]
    public string? CachedFileFolder { get; set; }

    /// <summary>Gets or sets the ClearData.</summary>
    [JsonPropertyName("ClearData")]
    public bool? ClearData { get; set; }

    /// <summary>Gets or sets the CreateDirectory.</summary>
    [JsonPropertyName("CreateDirectory")]
    public bool? CreateDirectory { get; set; }

    /// <summary>Gets or sets the EnableHTTPCompression.</summary>
    [JsonPropertyName("EnableHTTPCompression")]
    public bool? EnableHTTPCompression { get; set; }

    /// <summary>Gets or sets the RefreshChartCache.</summary>
    [JsonPropertyName("RefreshChartCache")]
    public bool? RefreshChartCache { get; set; }

    /// <summary>Gets or sets the SortNames.</summary>
    [JsonPropertyName("SortNames")]
    public bool? SortNames { get; set; }

    /// <summary>Gets or sets the ValidateMergedAreas.</summary>
    [JsonPropertyName("ValidateMergedAreas")]
    public bool? ValidateMergedAreas { get; set; }

    /// <summary>Gets or sets the MergeAreas.</summary>
    [JsonPropertyName("MergeAreas")]
    public bool? MergeAreas { get; set; }

    /// <summary>Gets or sets the SortExternalNames.</summary>
    [JsonPropertyName("SortExternalNames")]
    public bool? SortExternalNames { get; set; }

    /// <summary>Gets or sets the CheckExcelRestriction.</summary>
    [JsonPropertyName("CheckExcelRestriction")]
    public bool? CheckExcelRestriction { get; set; }

    /// <summary>Gets or sets the UpdateSmartArt.</summary>
    [JsonPropertyName("UpdateSmartArt")]
    public bool? UpdateSmartArt { get; set; }

    /// <summary>Gets or sets the EncryptDocumentProperties.</summary>
    [JsonPropertyName("EncryptDocumentProperties")]
    public bool? EncryptDocumentProperties { get; set; }

}
