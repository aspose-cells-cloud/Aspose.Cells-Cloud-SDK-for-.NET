using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CheckedExternalReferenceResponse model.</summary>
public class CheckedExternalReferenceResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the ReferenceOtherWorkbook.</summary>
    [JsonPropertyName("ReferenceOtherWorkbook")]
    public bool? ReferenceOtherWorkbook { get; set; }

    /// <summary>Gets or sets the ReferenceOtherWorksheet.</summary>
    [JsonPropertyName("ReferenceOtherWorksheet")]
    public bool? ReferenceOtherWorksheet { get; set; }

    /// <summary>Gets or sets the Formulas.</summary>
    [JsonPropertyName("Formulas")]
    public List<string>? Formulas { get; set; }

}
