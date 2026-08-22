using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SpreadsheetML2003SaveOptions model.</summary>
public class SpreadsheetML2003SaveOptions : SaveOptions
{
    /// <summary>Gets or sets the ExportColumnIndexOfCell.</summary>
    [JsonPropertyName("ExportColumnIndexOfCell")]
    public bool? ExportColumnIndexOfCell { get; set; }

    /// <summary>Gets or sets the IsIndentedFormatting.</summary>
    [JsonPropertyName("IsIndentedFormatting")]
    public bool? IsIndentedFormatting { get; set; }

    /// <summary>Gets or sets the LimitAsXls.</summary>
    [JsonPropertyName("LimitAsXls")]
    public bool? LimitAsXls { get; set; }

}
