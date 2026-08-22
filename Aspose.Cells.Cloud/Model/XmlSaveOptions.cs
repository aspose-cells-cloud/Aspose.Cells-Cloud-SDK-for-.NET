using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the XmlSaveOptions model.</summary>
public class XmlSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the SheetIndexes.</summary>
    [JsonPropertyName("SheetIndexes")]
    public List<int>? SheetIndexes { get; set; }

    /// <summary>Gets or sets the ExportArea.</summary>
    [JsonPropertyName("ExportArea")]
    public CellArea? ExportArea { get; set; }

    /// <summary>Gets or sets the HasHeaderRow.</summary>
    [JsonPropertyName("HasHeaderRow")]
    public bool? HasHeaderRow { get; set; }

    /// <summary>Gets or sets the XmlMapName.</summary>
    [JsonPropertyName("XmlMapName")]
    public string? XmlMapName { get; set; }

    /// <summary>Gets or sets the SheetNameAsElementName.</summary>
    [JsonPropertyName("SheetNameAsElementName")]
    public bool? SheetNameAsElementName { get; set; }

    /// <summary>Gets or sets the DataAsAttribute.</summary>
    [JsonPropertyName("DataAsAttribute")]
    public bool? DataAsAttribute { get; set; }

}
