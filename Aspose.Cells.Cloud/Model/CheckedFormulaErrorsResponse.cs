using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CheckedFormulaErrorsResponse model.</summary>
public class CheckedFormulaErrorsResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the IsFormulasErrors.</summary>
    [JsonPropertyName("IsFormulasErrors")]
    public bool? IsFormulasErrors { get; set; }

    /// <summary>Gets or sets the FormulasErrors.</summary>
    [JsonPropertyName("FormulasErrors")]
    public List<string>? FormulasErrors { get; set; }

}
