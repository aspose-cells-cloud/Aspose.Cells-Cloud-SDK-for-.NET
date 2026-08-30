using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the PivotTable model.</summary>
public class PivotTable : LinkElement
{
    /// <summary>Gets the description of the alt text</summary>
    [JsonPropertyName("AltTextDescription")]
    public string? AltTextDescription { get; set; }

    /// <summary>Gets or sets the AltTextTitle.</summary>
    [JsonPropertyName("AltTextTitle")]
    public string? AltTextTitle { get; set; }

    /// <summary>Gets or sets the AutoFormatType.</summary>
    [JsonPropertyName("AutoFormatType")]
    public string? AutoFormatType { get; set; }

    /// <summary>Gets or sets the BaseFields.</summary>
    [JsonPropertyName("BaseFields")]
    public List<PivotField>? BaseFields { get; set; }

    /// <summary>Gets or sets the ColumnFields.</summary>
    [JsonPropertyName("ColumnFields")]
    public List<PivotField>? ColumnFields { get; set; }

    /// <summary>Gets or sets the ColumnGrand.</summary>
    [JsonPropertyName("ColumnGrand")]
    public bool? ColumnGrand { get; set; }

    /// <summary>Gets or sets the ColumnHeaderCaption.</summary>
    [JsonPropertyName("ColumnHeaderCaption")]
    public string? ColumnHeaderCaption { get; set; }

    /// <summary>Gets or sets the ColumnRange.</summary>
    [JsonPropertyName("ColumnRange")]
    public CellArea? ColumnRange { get; set; }

    /// <summary>Gets or sets the CustomListSort.</summary>
    [JsonPropertyName("CustomListSort")]
    public bool? CustomListSort { get; set; }

    /// <summary>Gets or sets the DataBodyRange.</summary>
    [JsonPropertyName("DataBodyRange")]
    public CellArea? DataBodyRange { get; set; }

    /// <summary>Gets or sets the DataField.</summary>
    [JsonPropertyName("DataField")]
    public PivotField? DataField { get; set; }

    /// <summary>Gets or sets the DataFields.</summary>
    [JsonPropertyName("DataFields")]
    public List<PivotField>? DataFields { get; set; }

    /// <summary>Gets or sets the DataSource.</summary>
    [JsonPropertyName("DataSource")]
    public List<string>? DataSource { get; set; }

    /// <summary>Gets or sets the DisplayErrorString.</summary>
    [JsonPropertyName("DisplayErrorString")]
    public bool? DisplayErrorString { get; set; }

    /// <summary>Gets or sets the DisplayImmediateItems.</summary>
    [JsonPropertyName("DisplayImmediateItems")]
    public bool? DisplayImmediateItems { get; set; }

    /// <summary>Gets or sets the DisplayNullString.</summary>
    [JsonPropertyName("DisplayNullString")]
    public bool? DisplayNullString { get; set; }

    /// <summary>Gets or sets the EnableDataValueEditing.</summary>
    [JsonPropertyName("EnableDataValueEditing")]
    public bool? EnableDataValueEditing { get; set; }

    /// <summary>Gets or sets the EnableDrilldown.</summary>
    [JsonPropertyName("EnableDrilldown")]
    public bool? EnableDrilldown { get; set; }

    /// <summary>Gets or sets the EnableFieldDialog.</summary>
    [JsonPropertyName("EnableFieldDialog")]
    public bool? EnableFieldDialog { get; set; }

    /// <summary>Gets or sets the EnableFieldList.</summary>
    [JsonPropertyName("EnableFieldList")]
    public bool? EnableFieldList { get; set; }

    /// <summary>Gets or sets the EnableWizard.</summary>
    [JsonPropertyName("EnableWizard")]
    public bool? EnableWizard { get; set; }

    /// <summary>Gets or sets the ErrorString.</summary>
    [JsonPropertyName("ErrorString")]
    public string? ErrorString { get; set; }

    /// <summary>Gets or sets the FieldListSortAscending.</summary>
    [JsonPropertyName("FieldListSortAscending")]
    public bool? FieldListSortAscending { get; set; }

    /// <summary>Gets or sets the GrandTotalName.</summary>
    [JsonPropertyName("GrandTotalName")]
    public string? GrandTotalName { get; set; }

    /// <summary>Gets or sets the HasBlankRows.</summary>
    [JsonPropertyName("HasBlankRows")]
    public bool? HasBlankRows { get; set; }

    /// <summary>Gets or sets the Indent.</summary>
    [JsonPropertyName("Indent")]
    public int? Indent { get; set; }

    /// <summary>Gets or sets the IsAutoFormat.</summary>
    [JsonPropertyName("IsAutoFormat")]
    public bool? IsAutoFormat { get; set; }

    /// <summary>Gets or sets the IsGridDropZones.</summary>
    [JsonPropertyName("IsGridDropZones")]
    public bool? IsGridDropZones { get; set; }

    /// <summary>Gets or sets the IsMultipleFieldFilters.</summary>
    [JsonPropertyName("IsMultipleFieldFilters")]
    public bool? IsMultipleFieldFilters { get; set; }

    /// <summary>Gets or sets the IsSelected.</summary>
    [JsonPropertyName("IsSelected")]
    public bool? IsSelected { get; set; }

    /// <summary>Gets or sets the ItemPrintTitles.</summary>
    [JsonPropertyName("ItemPrintTitles")]
    public bool? ItemPrintTitles { get; set; }

    /// <summary>Gets or sets the ManualUpdate.</summary>
    [JsonPropertyName("ManualUpdate")]
    public bool? ManualUpdate { get; set; }

    /// <summary>Gets or sets the MergeLabels.</summary>
    [JsonPropertyName("MergeLabels")]
    public bool? MergeLabels { get; set; }

    /// <summary>Gets or sets the MissingItemsLimit.</summary>
    [JsonPropertyName("MissingItemsLimit")]
    public string? MissingItemsLimit { get; set; }

    /// <summary>Represents pivot table name.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the NullString.</summary>
    [JsonPropertyName("NullString")]
    public string? NullString { get; set; }

    /// <summary>Gets or sets the PageFieldOrder.</summary>
    [JsonPropertyName("PageFieldOrder")]
    public string? PageFieldOrder { get; set; }

    /// <summary>Gets or sets the PageFields.</summary>
    [JsonPropertyName("PageFields")]
    public List<PivotField>? PageFields { get; set; }

    /// <summary>Gets or sets the PageFieldWrapCount.</summary>
    [JsonPropertyName("PageFieldWrapCount")]
    public int? PageFieldWrapCount { get; set; }

    /// <summary>Gets or sets the PivotFilters.</summary>
    [JsonPropertyName("PivotFilters")]
    public List<PivotFilter>? PivotFilters { get; set; }

    /// <summary>Gets or sets the PivotTableStyleName.</summary>
    [JsonPropertyName("PivotTableStyleName")]
    public string? PivotTableStyleName { get; set; }

    /// <summary>Gets or sets the PivotTableStyleType.</summary>
    [JsonPropertyName("PivotTableStyleType")]
    public string? PivotTableStyleType { get; set; }

    /// <summary>Gets or sets the PreserveFormatting.</summary>
    [JsonPropertyName("PreserveFormatting")]
    public bool? PreserveFormatting { get; set; }

    /// <summary>Gets or sets the PrintDrill.</summary>
    [JsonPropertyName("PrintDrill")]
    public bool? PrintDrill { get; set; }

    /// <summary>Gets or sets the PrintTitles.</summary>
    [JsonPropertyName("PrintTitles")]
    public bool? PrintTitles { get; set; }

    /// <summary>Gets or sets the RefreshDataFlag.</summary>
    [JsonPropertyName("RefreshDataFlag")]
    public bool? RefreshDataFlag { get; set; }

    /// <summary>Gets or sets the RefreshDataOnOpeningFile.</summary>
    [JsonPropertyName("RefreshDataOnOpeningFile")]
    public bool? RefreshDataOnOpeningFile { get; set; }

    /// <summary>Gets or sets the RowFields.</summary>
    [JsonPropertyName("RowFields")]
    public List<PivotField>? RowFields { get; set; }

    /// <summary>Gets or sets the RowGrand.</summary>
    [JsonPropertyName("RowGrand")]
    public bool? RowGrand { get; set; }

    /// <summary>Gets or sets the RowHeaderCaption.</summary>
    [JsonPropertyName("RowHeaderCaption")]
    public string? RowHeaderCaption { get; set; }

    /// <summary>Gets or sets the RowRange.</summary>
    [JsonPropertyName("RowRange")]
    public CellArea? RowRange { get; set; }

    /// <summary>Gets or sets the SaveData.</summary>
    [JsonPropertyName("SaveData")]
    public bool? SaveData { get; set; }

    /// <summary>Gets or sets the ShowDataTips.</summary>
    [JsonPropertyName("ShowDataTips")]
    public bool? ShowDataTips { get; set; }

    /// <summary>Gets or sets the ShowDrill.</summary>
    [JsonPropertyName("ShowDrill")]
    public bool? ShowDrill { get; set; }

    /// <summary>Gets or sets the ShowEmptyCol.</summary>
    [JsonPropertyName("ShowEmptyCol")]
    public bool? ShowEmptyCol { get; set; }

    /// <summary>Gets or sets the ShowEmptyRow.</summary>
    [JsonPropertyName("ShowEmptyRow")]
    public bool? ShowEmptyRow { get; set; }

    /// <summary>Gets or sets the ShowMemberPropertyTips.</summary>
    [JsonPropertyName("ShowMemberPropertyTips")]
    public bool? ShowMemberPropertyTips { get; set; }

    /// <summary>Gets or sets the ShowPivotStyleColumnHeader.</summary>
    [JsonPropertyName("ShowPivotStyleColumnHeader")]
    public bool? ShowPivotStyleColumnHeader { get; set; }

    /// <summary>Gets or sets the ShowPivotStyleColumnStripes.</summary>
    [JsonPropertyName("ShowPivotStyleColumnStripes")]
    public bool? ShowPivotStyleColumnStripes { get; set; }

    /// <summary>Gets or sets the ShowPivotStyleLastColumn.</summary>
    [JsonPropertyName("ShowPivotStyleLastColumn")]
    public bool? ShowPivotStyleLastColumn { get; set; }

    /// <summary>Gets or sets the ShowPivotStyleRowHeader.</summary>
    [JsonPropertyName("ShowPivotStyleRowHeader")]
    public bool? ShowPivotStyleRowHeader { get; set; }

    /// <summary>Gets or sets the ShowPivotStyleRowStripes.</summary>
    [JsonPropertyName("ShowPivotStyleRowStripes")]
    public bool? ShowPivotStyleRowStripes { get; set; }

    /// <summary>Gets or sets the ShowRowHeaderCaption.</summary>
    [JsonPropertyName("ShowRowHeaderCaption")]
    public bool? ShowRowHeaderCaption { get; set; }

    /// <summary>Gets or sets the ShowValuesRow.</summary>
    [JsonPropertyName("ShowValuesRow")]
    public bool? ShowValuesRow { get; set; }

    /// <summary>Gets or sets the SubtotalHiddenPageItems.</summary>
    [JsonPropertyName("SubtotalHiddenPageItems")]
    public bool? SubtotalHiddenPageItems { get; set; }

    /// <summary>Gets or sets the TableRange1.</summary>
    [JsonPropertyName("TableRange1")]
    public CellArea? TableRange1 { get; set; }

    /// <summary>Gets or sets the TableRange2.</summary>
    [JsonPropertyName("TableRange2")]
    public CellArea? TableRange2 { get; set; }

    /// <summary>Gets or sets the Tag.</summary>
    [JsonPropertyName("Tag")]
    public string? Tag { get; set; }

}
