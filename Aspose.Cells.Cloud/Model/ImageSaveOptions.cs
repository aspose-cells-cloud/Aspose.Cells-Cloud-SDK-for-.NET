using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ImageSaveOptions model.</summary>
public class ImageSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the ChartImageType.</summary>
    [JsonPropertyName("ChartImageType")]
    public string? ChartImageType { get; set; }

    /// <summary>Gets or sets the EmbededImageNameInSvg.</summary>
    [JsonPropertyName("EmbededImageNameInSvg")]
    public string? EmbededImageNameInSvg { get; set; }

    /// <summary>Gets or sets the HorizontalResolution.</summary>
    [JsonPropertyName("HorizontalResolution")]
    public int? HorizontalResolution { get; set; }

    /// <summary>Gets or sets the ImageFormat.</summary>
    [JsonPropertyName("ImageFormat")]
    public string? ImageFormat { get; set; }

    /// <summary>Gets or sets the IsCellAutoFit.</summary>
    [JsonPropertyName("IsCellAutoFit")]
    public bool? IsCellAutoFit { get; set; }

    /// <summary>Gets or sets the OnePagePerSheet.</summary>
    [JsonPropertyName("OnePagePerSheet")]
    public bool? OnePagePerSheet { get; set; }

    /// <summary>Gets or sets the OnlyArea.</summary>
    [JsonPropertyName("OnlyArea")]
    public bool? OnlyArea { get; set; }

    /// <summary>Gets or sets the PrintingPage.</summary>
    [JsonPropertyName("PrintingPage")]
    public string? PrintingPage { get; set; }

    /// <summary>Gets or sets the PrintWithStatusDialog.</summary>
    [JsonPropertyName("PrintWithStatusDialog")]
    public bool? PrintWithStatusDialog { get; set; }

    /// <summary>Gets or sets the Quality.</summary>
    [JsonPropertyName("Quality")]
    public int? Quality { get; set; }

    /// <summary>Gets or sets the TiffCompression.</summary>
    [JsonPropertyName("TiffCompression")]
    public string? TiffCompression { get; set; }

    /// <summary>Gets or sets the VerticalResolution.</summary>
    [JsonPropertyName("VerticalResolution")]
    public int? VerticalResolution { get; set; }

}
