using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the DbfSaveOptions model.</summary>
public class DbfSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the ExportAsString.</summary>
    [JsonPropertyName("ExportAsString")]
    public bool? ExportAsString { get; set; }

}
