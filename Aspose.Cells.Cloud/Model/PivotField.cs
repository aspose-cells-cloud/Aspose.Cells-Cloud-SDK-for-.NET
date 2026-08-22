using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a field in a PivotTable report.</summary>
public class PivotField
{
    /// <summary>Represent the number of top or bottom items            that are automatically shown in the specified PivotTable field.</summary>
    [JsonPropertyName("AutoShowCount")]
    public int? AutoShowCount { get; set; }

    /// <summary>Gets or sets the AutoShowField.</summary>
    [JsonPropertyName("AutoShowField")]
    public int? AutoShowField { get; set; }

    /// <summary>Gets or sets the AutoSortField.</summary>
    [JsonPropertyName("AutoSortField")]
    public int? AutoSortField { get; set; }

    /// <summary>Gets or sets the BaseField.</summary>
    [JsonPropertyName("BaseField")]
    public int? BaseField { get; set; }

    /// <summary>Gets or sets the BaseIndex.</summary>
    [JsonPropertyName("BaseIndex")]
    public int? BaseIndex { get; set; }

    /// <summary>Gets or sets the BaseItem.</summary>
    [JsonPropertyName("BaseItem")]
    public int? BaseItem { get; set; }

    /// <summary>Gets or sets the BaseItemPosition.</summary>
    [JsonPropertyName("BaseItemPosition")]
    public string? BaseItemPosition { get; set; }

    /// <summary>Gets or sets the CurrentPageItem.</summary>
    [JsonPropertyName("CurrentPageItem")]
    public int? CurrentPageItem { get; set; }

    /// <summary>Gets or sets the DataDisplayFormat.</summary>
    [JsonPropertyName("DataDisplayFormat")]
    public string? DataDisplayFormat { get; set; }

    /// <summary>Gets or sets the DisplayName.</summary>
    [JsonPropertyName("DisplayName")]
    public string? DisplayName { get; set; }

    /// <summary>Gets or sets the DragToColumn.</summary>
    [JsonPropertyName("DragToColumn")]
    public bool? DragToColumn { get; set; }

    /// <summary>Gets or sets the DragToData.</summary>
    [JsonPropertyName("DragToData")]
    public bool? DragToData { get; set; }

    /// <summary>Gets or sets the DragToHide.</summary>
    [JsonPropertyName("DragToHide")]
    public bool? DragToHide { get; set; }

    /// <summary>Gets or sets the DragToPage.</summary>
    [JsonPropertyName("DragToPage")]
    public bool? DragToPage { get; set; }

    /// <summary>Gets or sets the DragToRow.</summary>
    [JsonPropertyName("DragToRow")]
    public bool? DragToRow { get; set; }

    /// <summary>Gets or sets the Function.</summary>
    [JsonPropertyName("Function")]
    public string? Function { get; set; }

    /// <summary>Gets or sets the InsertBlankRow.</summary>
    [JsonPropertyName("InsertBlankRow")]
    public bool? InsertBlankRow { get; set; }

    /// <summary>Gets or sets the IsAscendShow.</summary>
    [JsonPropertyName("IsAscendShow")]
    public bool? IsAscendShow { get; set; }

    /// <summary>Gets or sets the IsAscendSort.</summary>
    [JsonPropertyName("IsAscendSort")]
    public bool? IsAscendSort { get; set; }

    /// <summary>Gets or sets the IsAutoShow.</summary>
    [JsonPropertyName("IsAutoShow")]
    public bool? IsAutoShow { get; set; }

    /// <summary>Gets or sets the IsAutoSort.</summary>
    [JsonPropertyName("IsAutoSort")]
    public bool? IsAutoSort { get; set; }

    /// <summary>Gets or sets the IsAutoSubtotals.</summary>
    [JsonPropertyName("IsAutoSubtotals")]
    public bool? IsAutoSubtotals { get; set; }

    /// <summary>Gets or sets the IsCalculatedField.</summary>
    [JsonPropertyName("IsCalculatedField")]
    public bool? IsCalculatedField { get; set; }

    /// <summary>Gets or sets the IsIncludeNewItemsInFilter.</summary>
    [JsonPropertyName("IsIncludeNewItemsInFilter")]
    public bool? IsIncludeNewItemsInFilter { get; set; }

    /// <summary>Gets or sets the IsInsertPageBreaksBetweenItems.</summary>
    [JsonPropertyName("IsInsertPageBreaksBetweenItems")]
    public bool? IsInsertPageBreaksBetweenItems { get; set; }

    /// <summary>Gets or sets the IsMultipleItemSelectionAllowed.</summary>
    [JsonPropertyName("IsMultipleItemSelectionAllowed")]
    public bool? IsMultipleItemSelectionAllowed { get; set; }

    /// <summary>Gets or sets the IsRepeatItemLabels.</summary>
    [JsonPropertyName("IsRepeatItemLabels")]
    public bool? IsRepeatItemLabels { get; set; }

    /// <summary>Gets or sets the ItemCount.</summary>
    [JsonPropertyName("ItemCount")]
    public int? ItemCount { get; set; }

    /// <summary>Gets or sets the Items.</summary>
    [JsonPropertyName("Items")]
    public List<string>? Items { get; set; }

    /// <summary>Gets or sets the Name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the Number.</summary>
    [JsonPropertyName("Number")]
    public int? Number { get; set; }

    /// <summary>Gets or sets the NumberFormat.</summary>
    [JsonPropertyName("NumberFormat")]
    public string? NumberFormat { get; set; }

    /// <summary>Gets or sets the OriginalItems.</summary>
    [JsonPropertyName("OriginalItems")]
    public List<string>? OriginalItems { get; set; }

    /// <summary>Gets or sets the PivotItems.</summary>
    [JsonPropertyName("PivotItems")]
    public List<PivotItem>? PivotItems { get; set; }

    /// <summary>Gets or sets the Position.</summary>
    [JsonPropertyName("Position")]
    public int? Position { get; set; }

    /// <summary>Gets or sets the ShowAllItems.</summary>
    [JsonPropertyName("ShowAllItems")]
    public bool? ShowAllItems { get; set; }

    /// <summary>Gets or sets the ShowCompact.</summary>
    [JsonPropertyName("ShowCompact")]
    public bool? ShowCompact { get; set; }

    /// <summary>Gets or sets the ShowInOutlineForm.</summary>
    [JsonPropertyName("ShowInOutlineForm")]
    public bool? ShowInOutlineForm { get; set; }

    /// <summary>Gets or sets the ShowSubtotalAtTop.</summary>
    [JsonPropertyName("ShowSubtotalAtTop")]
    public bool? ShowSubtotalAtTop { get; set; }

}
