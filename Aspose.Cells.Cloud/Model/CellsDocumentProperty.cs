using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Cells document property.</summary>
public class CellsDocumentProperty
{
    /// <summary>Returns the name of the property.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the value of the property.</summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

    /// <summary>Indicates whether this property is linked to content</summary>
    [JsonPropertyName("IsLinkedToContent")]
    public string? IsLinkedToContent { get; set; }

    /// <summary>The linked content source.</summary>
    [JsonPropertyName("Source")]
    public string? Source { get; set; }

    /// <summary>Gets the data type of the property.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Returns true if this property does not have a name in the OLE2 storage and a</summary>
    [JsonPropertyName("IsGeneratedName")]
    public string? IsGeneratedName { get; set; }

}
