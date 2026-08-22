using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Settings of formulas and calculation.</summary>
public class FormulaSettings
{
    /// <summary>Indicates whether the application is required to perform a full calculation when the workbook is opened.</summary>
    [JsonPropertyName("CalculateOnOpen")]
    public bool? CalculateOnOpen { get; set; }

    /// <summary>Indicates whether recalculate the workbook before saving the document, when in manual calculation mode.</summary>
    [JsonPropertyName("CalculateOnSave")]
    public bool? CalculateOnSave { get; set; }

    /// <summary>Indicates whether calculates all formulas every time when a calculation is triggered.</summary>
    [JsonPropertyName("ForceFullCalculation")]
    public bool? ForceFullCalculation { get; set; }

    /// <summary>Gets or sets the mode for workbook calculation in ms excel.</summary>
    [JsonPropertyName("CalculationMode")]
    public string? CalculationMode { get; set; }

    /// <summary>Specifies the version of the calculation engine used to calculate values in the workbook.</summary>
    [JsonPropertyName("CalculationId")]
    public string? CalculationId { get; set; }

    /// <summary>Indicates whether enable iterative calculation to resolve circular references.</summary>
    [JsonPropertyName("EnableIterativeCalculation")]
    public bool? EnableIterativeCalculation { get; set; }

    /// <summary>The maximum iterations to resolve a circular reference.</summary>
    [JsonPropertyName("MaxIteration")]
    public int? MaxIteration { get; set; }

    /// <summary>The maximum change to resolve a circular reference.</summary>
    [JsonPropertyName("MaxChange")]
    public double? MaxChange { get; set; }

    /// <summary>Whether the precision of calculated result be set as they are displayed while calculating formulas</summary>
    [JsonPropertyName("PrecisionAsDisplayed")]
    public bool? PrecisionAsDisplayed { get; set; }

    /// <summary>Whether enable calculation chain for formulas. Default is false.</summary>
    [JsonPropertyName("EnableCalculationChain")]
    public bool? EnableCalculationChain { get; set; }

    /// <summary>Indicates whether preserve those spaces and line breaks that are padded between formula tokens</summary>
    [JsonPropertyName("PreservePaddingSpaces")]
    public bool? PreservePaddingSpaces { get; set; }

}
