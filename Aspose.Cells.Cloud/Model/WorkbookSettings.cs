using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents all settings of the workbook.</summary>
public class WorkbookSettings
{
    /// <summary>Specifies a boolean value that indicates the application automatically compressed pictures in the workbook.</summary>
    [JsonPropertyName("AutoCompressPictures")]
    public bool? AutoCompressPictures { get; set; }

    /// <summary>Indicates whether the file is mark for auto-recovery.</summary>
    [JsonPropertyName("AutoRecover")]
    public bool? AutoRecover { get; set; }

    /// <summary>Specifies the incremental public release of the application.</summary>
    [JsonPropertyName("BuildVersion")]
    public string? BuildVersion { get; set; }

    /// <summary>It specifies whether to calculate formulas manually,</summary>
    [JsonPropertyName("CalcMode")]
    public string? CalcMode { get; set; }

    /// <summary>Specifies the version of the calculation engine used to calculate values in the workbook.</summary>
    [JsonPropertyName("CalculationId")]
    public string? CalculationId { get; set; }

    /// <summary>Indicates whether check comptiliblity when saving workbook.</summary>
    [JsonPropertyName("CheckComptiliblity")]
    public bool? CheckComptiliblity { get; set; }

    /// <summary>Whether check restriction of excel file when user modify cells related objects.</summary>
    [JsonPropertyName("CheckExcelRestriction")]
    public bool? CheckExcelRestriction { get; set; }

    /// <summary>indicates whether the application last saved the workbook file after a crash.</summary>
    [JsonPropertyName("CrashSave")]
    public bool? CrashSave { get; set; }

    /// <summary>Whether creates calculated formulas chain. Default is false.</summary>
    [JsonPropertyName("CreateCalcChain")]
    public bool? CreateCalcChain { get; set; }

    /// <summary>indicates whether the application last opened the workbook for data recovery.</summary>
    [JsonPropertyName("DataExtractLoad")]
    public bool? DataExtractLoad { get; set; }

    /// <summary>Gets or sets a value which represents if the workbook uses the 1904 date system.</summary>
    [JsonPropertyName("Date1904")]
    public bool? Date1904 { get; set; }

    /// <summary>Indicates whether and how to show objects in the workbook.</summary>
    [JsonPropertyName("DisplayDrawingObjects")]
    public string? DisplayDrawingObjects { get; set; }

    /// <summary>Enable macros;</summary>
    [JsonPropertyName("EnableMacros")]
    public bool? EnableMacros { get; set; }

    /// <summary>Gets or sets the first visible worksheet tab.</summary>
    [JsonPropertyName("FirstVisibleTab")]
    public int? FirstVisibleTab { get; set; }

    /// <summary>Gets and sets whether hide the field list for the PivotTable.</summary>
    [JsonPropertyName("HidePivotFieldList")]
    public bool? HidePivotFieldList { get; set; }

    /// <summary>Indicates whether encrypting the workbook with default password if Structure and Windows of the workbook are locked.</summary>
    [JsonPropertyName("IsDefaultEncrypted")]
    public bool? IsDefaultEncrypted { get; set; }

    /// <summary>Indicates whether this workbook is hidden.</summary>
    [JsonPropertyName("IsHidden")]
    public bool? IsHidden { get; set; }

    /// <summary>Gets or sets a value indicating whether the generated spreadsheet will contain a horizontal scroll bar.</summary>
    [JsonPropertyName("IsHScrollBarVisible")]
    public bool? IsHScrollBarVisible { get; set; }

    /// <summary>Represents whether the generated spreadsheet will be opened Minimized.</summary>
    [JsonPropertyName("IsMinimized")]
    public bool? IsMinimized { get; set; }

    /// <summary>Gets or sets a value indicating whether the generated spreadsheet will contain a vertical scroll bar.</summary>
    [JsonPropertyName("IsVScrollBarVisible")]
    public bool? IsVScrollBarVisible { get; set; }

    /// <summary>Indicates whether enable iterative calculation to resolve circular references.</summary>
    [JsonPropertyName("Iteration")]
    public bool? Iteration { get; set; }

    /// <summary>Gets or sets the user interface language of the Workbook version based on CountryCode that has saved the file.</summary>
    [JsonPropertyName("LanguageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Returns or sets the maximum number of change to resolve a circular reference.</summary>
    [JsonPropertyName("MaxChange")]
    public double? MaxChange { get; set; }

    /// <summary>Returns or sets the maximum number of iterations to resolve a circular reference.</summary>
    [JsonPropertyName("MaxIteration")]
    public int? MaxIteration { get; set; }

    /// <summary>Gets or sets the memory usage options. The new option will be taken as the default option for newly created worksheets but does not take effect for existing worksheets.</summary>
    [JsonPropertyName("MemorySetting")]
    public string? MemorySetting { get; set; }

    /// <summary>Gets or sets the decimal separator for formatting/parsing numeric values. Default is the decimal separator of current Region.</summary>
    [JsonPropertyName("NumberDecimalSeparator")]
    public string? NumberDecimalSeparator { get; set; }

    /// <summary>Gets or sets the character that separates groups of digits to the left of the decimal in numeric values. Default is the group separator of current Region.</summary>
    [JsonPropertyName("NumberGroupSeparator")]
    public string? NumberGroupSeparator { get; set; }

    /// <summary>Indicates whether parsing the formula when reading the file.</summary>
    [JsonPropertyName("ParsingFormulaOnOpen")]
    public bool? ParsingFormulaOnOpen { get; set; }

    /// <summary>True if calculations in this workbook will be done using only the precision of the numbers as they're displayed</summary>
    [JsonPropertyName("PrecisionAsDisplayed")]
    public bool? PrecisionAsDisplayed { get; set; }

    /// <summary>Indicates whether to recalculate before saving the document.</summary>
    [JsonPropertyName("RecalculateBeforeSave")]
    public bool? RecalculateBeforeSave { get; set; }

    /// <summary>Indicates whether re-calculate all formulas on opening file.</summary>
    [JsonPropertyName("ReCalculateOnOpen")]
    public bool? ReCalculateOnOpen { get; set; }

    /// <summary>Indicates if the Read Only Recommended option is selected.</summary>
    [JsonPropertyName("RecommendReadOnly")]
    public bool? RecommendReadOnly { get; set; }

    /// <summary>Gets or sets the regional settings for workbook.</summary>
    [JsonPropertyName("Region")]
    public string? Region { get; set; }

    /// <summary>True if personal information can be removed from the specified workbook.</summary>
    [JsonPropertyName("RemovePersonalInformation")]
    public bool? RemovePersonalInformation { get; set; }

    /// <summary>Indicates whether the application last opened the workbook in safe or repair mode.</summary>
    [JsonPropertyName("RepairLoad")]
    public bool? RepairLoad { get; set; }

    /// <summary>Gets or sets a value that indicates whether the Workbook is shared.</summary>
    [JsonPropertyName("Shared")]
    public bool? Shared { get; set; }

    /// <summary>Width of worksheet tab bar (in 1/1000 of window width).</summary>
    [JsonPropertyName("SheetTabBarWidth")]
    public int? SheetTabBarWidth { get; set; }

    /// <summary>Get or sets a value whether the Workbook tabs are displayed.</summary>
    [JsonPropertyName("ShowTabs")]
    public bool? ShowTabs { get; set; }

    /// <summary>Indicates whether update adjacent cells' border.</summary>
    [JsonPropertyName("UpdateAdjacentCellsBorder")]
    public bool? UpdateAdjacentCellsBorder { get; set; }

    /// <summary>Gets and sets how updates external links when the workbook is opened.</summary>
    [JsonPropertyName("UpdateLinksType")]
    public string? UpdateLinksType { get; set; }

    /// <summary>The height of the window, in unit of point.</summary>
    [JsonPropertyName("WindowHeight")]
    public double? WindowHeight { get; set; }

    /// <summary>The distance from the left edge of the client area to the left edge of the window, in unit of point.</summary>
    [JsonPropertyName("WindowLeft")]
    public double? WindowLeft { get; set; }

    /// <summary>The distance from the top edge of the client area to the top edge of the window, in unit of point.</summary>
    [JsonPropertyName("WindowTop")]
    public double? WindowTop { get; set; }

    /// <summary>The width of the window, in unit of point.</summary>
    [JsonPropertyName("WindowWidth")]
    public double? WindowWidth { get; set; }

    /// <summary>Gets and sets the author of the file.</summary>
    [JsonPropertyName("Author")]
    public string? Author { get; set; }

    /// <summary>Indicates whether checking custom number format when setting Style.Custom.</summary>
    [JsonPropertyName("CheckCustomNumberFormat")]
    public bool? CheckCustomNumberFormat { get; set; }

    /// <summary>Gets the protection type of the workbook.</summary>
    [JsonPropertyName("ProtectionType")]
    public string? ProtectionType { get; set; }

    /// <summary>Gets and sets the globalization settings.</summary>
    [JsonPropertyName("GlobalizationSettings")]
    public GlobalizationSettings? GlobalizationSettings { get; set; }

    /// <summary>Represents Workbook file encryption password.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

    /// <summary>Provides access to the workbook write protection options.</summary>
    [JsonPropertyName("WriteProtection")]
    public WriteProtection? WriteProtection { get; set; }

    /// <summary>Gets a value that indicates whether a password is required to open this workbook.</summary>
    [JsonPropertyName("IsEncrypted")]
    public bool? IsEncrypted { get; set; }

    /// <summary>Gets a value that indicates whether the structure or window of the Workbook is protected.</summary>
    [JsonPropertyName("IsProtected")]
    public bool? IsProtected { get; set; }

    /// <summary>Gets the max row index, zero-based.</summary>
    [JsonPropertyName("MaxRow")]
    public int? MaxRow { get; set; }

    /// <summary>Gets the max column index, zero-based.</summary>
    [JsonPropertyName("MaxColumn")]
    public int? MaxColumn { get; set; }

    /// <summary>Gets and sets the number of significant digits.</summary>
    [JsonPropertyName("SignificantDigits")]
    public int? SignificantDigits { get; set; }

    /// <summary>Indicates whether check compatibility with earlier versions when saving workbook.</summary>
    [JsonPropertyName("CheckCompatibility")]
    public bool? CheckCompatibility { get; set; }

    /// <summary>Gets and sets the default print paper size.</summary>
    [JsonPropertyName("PaperSize")]
    public string? PaperSize { get; set; }

    /// <summary>Gets and sets the max row number of shared formula.</summary>
    [JsonPropertyName("MaxRowsOfSharedFormula")]
    public int? MaxRowsOfSharedFormula { get; set; }

    /// <summary>Specifies the OOXML version for the output document. The default value is Ecma376_2006.</summary>
    [JsonPropertyName("Compliance")]
    public string? Compliance { get; set; }

    /// <summary>Indicates whether setting  property when entering the string value(which starts  with single quote mark ) to the cell</summary>
    [JsonPropertyName("QuotePrefixToStyle")]
    public bool? QuotePrefixToStyle { get; set; }

    /// <summary>Gets the settings for formula-related features.</summary>
    [JsonPropertyName("FormulaSettings")]
    public FormulaSettings? FormulaSettings { get; set; }

    /// <summary>Fully calculates every time when a calculation is triggered.</summary>
    [JsonPropertyName("ForceFullCalculate")]
    public bool? ForceFullCalculate { get; set; }

}
