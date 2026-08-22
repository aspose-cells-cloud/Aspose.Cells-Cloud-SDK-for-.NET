using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Specifies the range of cells within the worksheet where the spreadsheet operations will be performed. This parameter allows users to define the exact area to be processed, ensuring that operations are applied only to the designated cells.</summary>
public class ScopeOptions
{
    /// <summary>ScopeOptionsType is a type that represents options or settings that are specific to a particular scope.</summary>
    [JsonPropertyName("Scope")]
    public string? Scope { get; set; }

    /// <summary>Specifies the designated work area within the worksheet where operations are to be performed.</summary>
    [JsonPropertyName("ScopeItems")]
    public List<ScopeItem>? ScopeItems { get; set; }

}
