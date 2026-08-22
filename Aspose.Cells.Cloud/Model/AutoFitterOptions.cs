using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents all auto fitter options.</summary>
public class AutoFitterOptions
{
    /// <summary>Gets and set the type of auto fitting row height of merged cells.</summary>
    [JsonPropertyName("AutoFitMergedCellsType")]
    public string? AutoFitMergedCellsType { get; set; }

    /// <summary>Ignores the hidden rows/columns.</summary>
    [JsonPropertyName("IgnoreHidden")]
    public bool? IgnoreHidden { get; set; }

    /// <summary>Indicates whether only fit the rows which height are not customed.</summary>
    [JsonPropertyName("OnlyAuto")]
    public bool? OnlyAuto { get; set; }

    /// <summary>Gets or sets default edit language.</summary>
    [JsonPropertyName("DefaultEditLanguage")]
    public string? DefaultEditLanguage { get; set; }

    /// <summary>Gets and sets the max row height(in unit of Point) when autofitting rows.</summary>
    [JsonPropertyName("MaxRowHeight")]
    public double? MaxRowHeight { get; set; }

    /// <summary>Gets and sets the type of auto fitting wrapped text.</summary>
    [JsonPropertyName("AutoFitWrappedTextType")]
    public string? AutoFitWrappedTextType { get; set; }

    /// <summary>Gets and sets the formatted strategy.</summary>
    [JsonPropertyName("FormatStrategy")]
    public string? FormatStrategy { get; set; }

    /// <summary>Indicates whether fit for rendering purpose.</summary>
    [JsonPropertyName("ForRendering")]
    public bool? ForRendering { get; set; }

}
