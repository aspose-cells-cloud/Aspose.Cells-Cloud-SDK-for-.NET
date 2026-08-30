using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ImportPosition model.</summary>
public class ImportPosition
{
    /// <summary>"Property SheetName of type string with a public get and set accessor."</summary>
    [JsonPropertyName("SheetName")]
    public string? SheetName { get; set; }

    /// <summary>Gets or sets the RowIndex.</summary>
    [JsonPropertyName("RowIndex")]
    public int? RowIndex { get; set; }

    /// <summary>Gets or sets the ColumnIndex.</summary>
    [JsonPropertyName("ColumnIndex")]
    public int? ColumnIndex { get; set; }

}
