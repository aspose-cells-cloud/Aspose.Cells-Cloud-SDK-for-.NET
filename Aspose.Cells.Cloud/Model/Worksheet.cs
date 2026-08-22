using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a single worksheet.</summary>
public class Worksheet
{
    /// <summary>Property Summary: Contains a list of links represented by the class link.</summary>
    [JsonPropertyName("Links")]
    public List<Link>? Links { get; set; }

    /// <summary>Indicates if the specified worksheet is displayed from right to left instead of from left to right.</summary>
    [JsonPropertyName("DisplayRightToLeft")]
    public bool? DisplayRightToLeft { get; set; }

    /// <summary>True if zero values are displayed.</summary>
    [JsonPropertyName("DisplayZeros")]
    public bool? DisplayZeros { get; set; }

    /// <summary>Represents first visible column index.</summary>
    [JsonPropertyName("FirstVisibleColumn")]
    public int? FirstVisibleColumn { get; set; }

    /// <summary>Represents first visible row index.</summary>
    [JsonPropertyName("FirstVisibleRow")]
    public int? FirstVisibleRow { get; set; }

    /// <summary>Gets or sets the name of the worksheet.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets the index of sheet in the worksheet collection.</summary>
    [JsonPropertyName("Index")]
    public int? Index { get; set; }

    /// <summary>Gets or sets a value indicating whether the gridlines are visible.Default is true.</summary>
    [JsonPropertyName("IsGridlinesVisible")]
    public bool? IsGridlinesVisible { get; set; }

    /// <summary>Indicates whether to show outline.</summary>
    [JsonPropertyName("IsOutlineShown")]
    public bool? IsOutlineShown { get; set; }

    /// <summary>Indicates whether the specified worksheet is shown in normal view or page break preview.</summary>
    [JsonPropertyName("IsPageBreakPreview")]
    public bool? IsPageBreakPreview { get; set; }

    /// <summary>Represents if the worksheet is visible.</summary>
    [JsonPropertyName("IsVisible")]
    public bool? IsVisible { get; set; }

    /// <summary>Indicates if the worksheet is protected.</summary>
    [JsonPropertyName("IsProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>Gets or sets a value indicating whether the worksheet will display row and column headers.</summary>
    [JsonPropertyName("IsRowColumnHeadersVisible")]
    public bool? IsRowColumnHeadersVisible { get; set; }

    /// <summary>Indicates whether the ruler is visible. This property is only applied for page break preview.</summary>
    [JsonPropertyName("IsRulerVisible")]
    public bool? IsRulerVisible { get; set; }

    /// <summary>Indicates whether this worksheet is selected when the workbook is opened.</summary>
    [JsonPropertyName("IsSelected")]
    public bool? IsSelected { get; set; }

    /// <summary>Represents worksheet tab color.</summary>
    [JsonPropertyName("TabColor")]
    public Color? TabColor { get; set; }

    /// <summary>Indicates whether the Transition Formula Entry (Lotus compatibility) option is enabled.</summary>
    [JsonPropertyName("TransitionEntry")]
    public bool? TransitionEntry { get; set; }

    /// <summary>Indicates whether the Transition Formula Evaluation (Lotus compatibility) option is enabled.</summary>
    [JsonPropertyName("TransitionEvaluation")]
    public bool? TransitionEvaluation { get; set; }

    /// <summary>Represents worksheet type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets and sets the view type.</summary>
    [JsonPropertyName("ViewType")]
    public string? ViewType { get; set; }

    /// <summary>Indicates the visible state for this sheet.</summary>
    [JsonPropertyName("VisibilityType")]
    public string? VisibilityType { get; set; }

    /// <summary>Represents the scaling factor in percentage. It should be between 10 and 400.</summary>
    [JsonPropertyName("Zoom")]
    public int? Zoom { get; set; }

    /// <summary>Gets the  collection.</summary>
    [JsonPropertyName("Cells")]
    public LinkElement? Cells { get; set; }

    /// <summary>Gets a  collection</summary>
    [JsonPropertyName("Charts")]
    public LinkElement? Charts { get; set; }

    /// <summary>Gets or sets the AutoShapes.</summary>
    [JsonPropertyName("AutoShapes")]
    public LinkElement? AutoShapes { get; set; }

    /// <summary>Represents a collection of  in a worksheet.</summary>
    [JsonPropertyName("OleObjects")]
    public LinkElement? OleObjects { get; set; }

    /// <summary>Gets the  collection.</summary>
    [JsonPropertyName("Comments")]
    public LinkElement? Comments { get; set; }

    /// <summary>Gets a  collection.</summary>
    [JsonPropertyName("Pictures")]
    public LinkElement? Pictures { get; set; }

    /// <summary>Gets or sets the MergedCells.</summary>
    [JsonPropertyName("MergedCells")]
    public LinkElement? MergedCells { get; set; }

    /// <summary>Gets the data validation setting collection in the worksheet.</summary>
    [JsonPropertyName("Validations")]
    public LinkElement? Validations { get; set; }

    /// <summary>Gets the ConditionalFormattings in the worksheet.</summary>
    [JsonPropertyName("ConditionalFormattings")]
    public LinkElement? ConditionalFormattings { get; set; }

    /// <summary>Gets the  collection.</summary>
    [JsonPropertyName("Hyperlinks")]
    public LinkElement? Hyperlinks { get; set; }

}
