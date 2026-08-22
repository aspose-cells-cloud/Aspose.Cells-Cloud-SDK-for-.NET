using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Monitor for user to track the progress of formula calculation.</summary>
public class AbstractCalculationMonitor
{
    /// <summary>Gets the old value of the calculated cell. Should be used only in  and .</summary>
    [JsonPropertyName("OriginalValue")]
    public object? OriginalValue { get; set; }

    /// <summary>Whether the cell's value has been changed after the calculation.  Should be used only in .</summary>
    [JsonPropertyName("ValueChanged")]
    public bool? ValueChanged { get; set; }

    /// <summary>Gets the newly calculated value of the cell. Should be used only in .</summary>
    [JsonPropertyName("CalculatedValue")]
    public object? CalculatedValue { get; set; }

}
