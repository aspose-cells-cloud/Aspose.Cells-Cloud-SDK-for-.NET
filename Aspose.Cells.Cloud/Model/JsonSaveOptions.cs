using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the JsonSaveOptions model.</summary>
public class JsonSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the ExportArea.</summary>
    [JsonPropertyName("ExportArea")]
    public CellArea? ExportArea { get; set; }

    /// <summary>Gets or sets the HasHeaderRow.</summary>
    [JsonPropertyName("HasHeaderRow")]
    public bool? HasHeaderRow { get; set; }

    /// <summary>Gets or sets the ExportAsString.</summary>
    [JsonPropertyName("ExportAsString")]
    public bool? ExportAsString { get; set; }

    /// <summary>Gets or sets the Indent.</summary>
    [JsonPropertyName("Indent")]
    public string? Indent { get; set; }

}
