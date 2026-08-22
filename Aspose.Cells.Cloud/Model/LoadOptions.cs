using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the options of loading the file.</summary>
public class LoadOptions
{
    /// <summary>This class has a public property named "ConvertNumericData" of type string that can be read from and written to.</summary>
    [JsonPropertyName("ConvertNumericData")]
    public string? ConvertNumericData { get; set; }

    /// <summary>Gets and sets the interrupt monitor.</summary>
    [JsonPropertyName("InterruptMonitor")]
    public string? InterruptMonitor { get; set; }

    /// <summary>Gets or sets the user interface language of the Workbook version based on CountryCode that has saved the file.</summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Gets or sets the LoadDataOptions.</summary>
    [JsonPropertyName("LoadDataOptions")]
    public string? LoadDataOptions { get; set; }

    /// <summary>Gets the load format.</summary>
    [JsonPropertyName("LoadFormat")]
    public string? LoadFormat { get; set; }

    /// <summary>Gets or sets the OnlyLoadDocumentProperties.</summary>
    [JsonPropertyName("OnlyLoadDocumentProperties")]
    public string? OnlyLoadDocumentProperties { get; set; }

    /// <summary>Indicates whether parsing the formula when reading the file.</summary>
    [JsonPropertyName("ParsingFormulaOnOpen")]
    public string? ParsingFormulaOnOpen { get; set; }

    /// <summary>Gets and set the password of the workbook.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

    /// <summary>Gets or sets the system regional settings based on CountryCode at the time the file was loaded.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

    /// <summary>Sets the default standard font name</summary>
    [JsonPropertyName("StandardFont")]
    public string? StandardFont { get; set; }

    /// <summary>Sets the default standard font size.</summary>
    [JsonPropertyName("StandardFontSize")]
    public double? StandardFontSize { get; set; }

}
