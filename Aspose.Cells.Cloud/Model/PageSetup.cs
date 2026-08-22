using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>excel print page setting</summary>
public class PageSetup
{
    /// <summary>Represents if elements of the document will be printed in black and white.</summary>
    [JsonPropertyName("BlackAndWhite")]
    public bool? BlackAndWhite { get; set; }

    /// <summary>Represents the size of the bottom margin, in unit of centimeters.</summary>
    [JsonPropertyName("BottomMargin")]
    public double? BottomMargin { get; set; }

    /// <summary>Represent if the sheet is printed centered horizontally.</summary>
    [JsonPropertyName("CenterHorizontally")]
    public bool? CenterHorizontally { get; set; }

    /// <summary>Represent if the sheet is printed centered vertically.</summary>
    [JsonPropertyName("CenterVertically")]
    public bool? CenterVertically { get; set; }

    /// <summary>Represents the first page number that will be used when this sheet is printed.</summary>
    [JsonPropertyName("FirstPageNumber")]
    public int? FirstPageNumber { get; set; }

    /// <summary>Represents  the number of pages tall the worksheet will be scaled to when it's printed.</summary>
    [JsonPropertyName("FitToPagesTall")]
    public int? FitToPagesTall { get; set; }

    /// <summary>Represents the number of pages wide the worksheet will be scaled to when it's printed.</summary>
    [JsonPropertyName("FitToPagesWide")]
    public int? FitToPagesWide { get; set; }

    /// <summary>Represents the distance from the bottom of the page to the footer, in unit of centimeters.</summary>
    [JsonPropertyName("FooterMargin")]
    public double? FooterMargin { get; set; }

    /// <summary>Represents the distance from the top of the page to the header, in unit of centimeters.</summary>
    [JsonPropertyName("HeaderMargin")]
    public double? HeaderMargin { get; set; }

    /// <summary>Indicates whether the first the page number is automatically assigned.</summary>
    [JsonPropertyName("IsAutoFirstPageNumber")]
    public bool? IsAutoFirstPageNumber { get; set; }

    /// <summary>Indicates whether header and footer margins are aligned with the page margins.</summary>
    [JsonPropertyName("IsHFAlignMargins")]
    public bool? IsHFAlignMargins { get; set; }

    /// <summary>True means that the header/footer of the first page is different with other pages.</summary>
    [JsonPropertyName("IsHFDiffFirst")]
    public bool? IsHFDiffFirst { get; set; }

    /// <summary>True means that the header/footer of the odd pages is different with odd pages.</summary>
    [JsonPropertyName("IsHFDiffOddEven")]
    public bool? IsHFDiffOddEven { get; set; }

    /// <summary>Indicates whether header and footer are scaled with document scaling.</summary>
    [JsonPropertyName("IsHFScaleWithDoc")]
    public bool? IsHFScaleWithDoc { get; set; }

    /// <summary>If this property is False, the FitToPagesWide and FitToPagesTall properties control how the worksheet is scaled.</summary>
    [JsonPropertyName("IsPercentScale")]
    public bool? IsPercentScale { get; set; }

    /// <summary>Represents the size of the left margin, in unit of centimeters.</summary>
    [JsonPropertyName("LeftMargin")]
    public double? LeftMargin { get; set; }

    /// <summary>Represents the order that Microsoft Excel uses to number pages when printing a large worksheet.</summary>
    [JsonPropertyName("Order")]
    public string? Order { get; set; }

    /// <summary>Represents page print orientation.</summary>
    [JsonPropertyName("Orientation")]
    public string? Orientation { get; set; }

    /// <summary>Represents the size of the paper.</summary>
    [JsonPropertyName("PaperSize")]
    public string? PaperSize { get; set; }

    /// <summary>Represents the range to be printed.</summary>
    [JsonPropertyName("PrintArea")]
    public string? PrintArea { get; set; }

    /// <summary>Represents the way comments are printed with the sheet.</summary>
    [JsonPropertyName("PrintComments")]
    public string? PrintComments { get; set; }

    /// <summary>Get and sets number of copies to print.</summary>
    [JsonPropertyName("PrintCopies")]
    public int? PrintCopies { get; set; }

    /// <summary>Represents if the sheet will be printed without graphics.</summary>
    [JsonPropertyName("PrintDraft")]
    public bool? PrintDraft { get; set; }

    /// <summary>Specifies the type of print error displayed.</summary>
    [JsonPropertyName("PrintErrors")]
    public string? PrintErrors { get; set; }

    /// <summary>Represents if cell gridlines are printed on the page.</summary>
    [JsonPropertyName("PrintGridlines")]
    public bool? PrintGridlines { get; set; }

    /// <summary>Represents if row and column headings are printed with this page.</summary>
    [JsonPropertyName("PrintHeadings")]
    public bool? PrintHeadings { get; set; }

    /// <summary>Represents the print quality.</summary>
    [JsonPropertyName("PrintQuality")]
    public int? PrintQuality { get; set; }

    /// <summary>Represents the columns that contain the cells to be repeated on the left side of each page.</summary>
    [JsonPropertyName("PrintTitleColumns")]
    public string? PrintTitleColumns { get; set; }

    /// <summary>Represents the rows that contain the cells to be repeated at the top of each page.</summary>
    [JsonPropertyName("PrintTitleRows")]
    public string? PrintTitleRows { get; set; }

    /// <summary>Represents the size of the right margin, in unit of centimeters.</summary>
    [JsonPropertyName("RightMargin")]
    public double? RightMargin { get; set; }

    /// <summary>Represents the size of the top margin, in unit of centimeters.</summary>
    [JsonPropertyName("TopMargin")]
    public double? TopMargin { get; set; }

    /// <summary>Represents the scaling factor in percent. It should be between 10 and 400.</summary>
    [JsonPropertyName("Zoom")]
    public int? Zoom { get; set; }

    /// <summary>Represents the page header.</summary>
    [JsonPropertyName("Header")]
    public List<PageSection>? Header { get; set; }

    /// <summary>Represents the page footor.</summary>
    [JsonPropertyName("Footer")]
    public List<PageSection>? Footer { get; set; }

}
