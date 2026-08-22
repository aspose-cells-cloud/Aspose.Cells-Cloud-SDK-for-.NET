using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents an OleObject in a worksheet.</summary>
public class OleObject : Shape
{
    /// <summary>True if the specified object is displayed as an icon</summary>
    [JsonPropertyName("DisplayAsIcon")]
    public bool? DisplayAsIcon { get; set; }

    /// <summary>Gets and sets the file type of the embedded ole object data</summary>
    [JsonPropertyName("FileFormatType")]
    public string? FileFormatType { get; set; }

    /// <summary>Gets or sets the path and name of the source file for the linked image.</summary>
    [JsonPropertyName("ImageSourceFullName")]
    public string? ImageSourceFullName { get; set; }

    /// <summary>True indicates that the size of the ole object will be auto changed as the size of snapshot of the embedded content</summary>
    [JsonPropertyName("IsAutoSize")]
    public bool? IsAutoSize { get; set; }

    /// <summary>Returns true if the OleObject links to the file.</summary>
    [JsonPropertyName("IsLink")]
    public bool? IsLink { get; set; }

    /// <summary>Gets or sets the ProgID of the OLE object.</summary>
    [JsonPropertyName("ProgID")]
    public string? ProgID { get; set; }

    /// <summary>Returns the source full name of the source file for the linked OLE object.</summary>
    [JsonPropertyName("SourceFullName")]
    public string? SourceFullName { get; set; }

}
