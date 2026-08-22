using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the copy options.</summary>
public class CopyOptions
{
    /// <summary>Indicates whether copying column width in unit of characters.</summary>
    [JsonPropertyName("ColumnCharacterWidth")]
    public bool? ColumnCharacterWidth { get; set; }

    /// <summary>If the formula is not valid for the dest destination, only copy values.</summary>
    [JsonPropertyName("CopyInvalidFormulasAsValues")]
    public bool? CopyInvalidFormulasAsValues { get; set; }

    /// <summary>Indicates whether copying the names.</summary>
    [JsonPropertyName("CopyNames")]
    public bool? CopyNames { get; set; }

    /// <summary>Indicates whether extend ranges when copying the range to adjacent range.</summary>
    [JsonPropertyName("ExtendToAdjacentRange")]
    public bool? ExtendToAdjacentRange { get; set; }

    /// <summary>When copying the range in the same file and the chart refers to the source sheet,</summary>
    [JsonPropertyName("ReferToDestinationSheet")]
    public bool? ReferToDestinationSheet { get; set; }

    /// <summary>In ms excel, when copying formulas which refer to other worksheets while copying a worksheet to another one,</summary>
    [JsonPropertyName("ReferToSheetWithSameName")]
    public bool? ReferToSheetWithSameName { get; set; }

    /// <summary>Gets or sets the CopyTheme.</summary>
    [JsonPropertyName("CopyTheme")]
    public bool? CopyTheme { get; set; }

}
