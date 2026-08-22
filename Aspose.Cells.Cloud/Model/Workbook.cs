using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a root object to create an Excel spreadsheet.</summary>
public class Workbook
{
    /// <summary>Gets and sets the current file name.</summary>
    [JsonPropertyName("FileName")]
    public string? FileName { get; set; }

    /// <summary>A property of type List Link  named Links is specified to be serialized as an XmlElement with the tag "link".</summary>
    [JsonPropertyName("Links")]
    public List<Link>? Links { get; set; }

    /// <summary>Gets the  collection in the spreadsheet.</summary>
    [JsonPropertyName("Worksheets")]
    public LinkElement? Worksheets { get; set; }

    /// <summary>Gets or sets the default  object of the workbook.</summary>
    [JsonPropertyName("DefaultStyle")]
    public LinkElement? DefaultStyle { get; set; }

    /// <summary>Gets or sets the DocumentProperties.</summary>
    [JsonPropertyName("DocumentProperties")]
    public LinkElement? DocumentProperties { get; set; }

    /// <summary>Gets or sets the Names.</summary>
    [JsonPropertyName("Names")]
    public LinkElement? Names { get; set; }

    /// <summary>Represents the workbook settings.</summary>
    [JsonPropertyName("Settings")]
    public LinkElement? Settings { get; set; }

    /// <summary>Gets or sets the IsWriteProtected.</summary>
    [JsonPropertyName("IsWriteProtected")]
    public string? IsWriteProtected { get; set; }

    /// <summary>Gets or sets the IsProtected.</summary>
    [JsonPropertyName("IsProtected")]
    public string? IsProtected { get; set; }

    /// <summary>Gets or sets the IsEncryption.</summary>
    [JsonPropertyName("IsEncryption")]
    public string? IsEncryption { get; set; }

    /// <summary>Gets or sets the Password.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

}
