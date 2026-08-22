using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents options for calculation.</summary>
public class CalculationOptions
{
    /// <summary>Specifies the stack size for calculating cells recursively.</summary>
    [JsonPropertyName("CalcStackSize")]
    public int? CalcStackSize { get; set; }

    /// <summary>Indicates whether errors encountered while calculating formulas should be ignored.</summary>
    [JsonPropertyName("IgnoreError")]
    public bool? IgnoreError { get; set; }

    /// <summary>Specifies the strategy for processing precision of calculation.</summary>
    [JsonPropertyName("PrecisionStrategy")]
    public string? PrecisionStrategy { get; set; }

    /// <summary>Indicates whether calculate the dependent cells recursively when calculating one cell and it depends on other cells.</summary>
    [JsonPropertyName("Recursive")]
    public bool? Recursive { get; set; }

    /// <summary>The custom formula calculation engine to extend the default calculation engine of Aspose.Cells.</summary>
    [JsonPropertyName("CustomEngine")]
    public AbstractCalculationEngine? CustomEngine { get; set; }

    /// <summary>The monitor for user to track the progress of formula calculation.</summary>
    [JsonPropertyName("CalculationMonitor")]
    public AbstractCalculationMonitor? CalculationMonitor { get; set; }

    /// <summary>Specifies the data sources for external links used in formulas.</summary>
    [JsonPropertyName("LinkedDataSources")]
    public List<Workbook>? LinkedDataSources { get; set; }

}
