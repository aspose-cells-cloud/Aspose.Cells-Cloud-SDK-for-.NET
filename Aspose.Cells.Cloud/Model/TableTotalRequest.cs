using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Indicates table total request</summary>
public class TableTotalRequest
{
    /// <summary>Indicates list column index.</summary>
    [JsonPropertyName("ListColumnIndex")]
    public int? ListColumnIndex { get; set; }

    /// <summary>Indicates totals calculation.</summary>
    [JsonPropertyName("TotalsCalculation")]
    public string? TotalsCalculation { get; set; }

    /// <summary>Indicates custom formula.</summary>
    [JsonPropertyName("CustomFormula")]
    public string? CustomFormula { get; set; }

}
