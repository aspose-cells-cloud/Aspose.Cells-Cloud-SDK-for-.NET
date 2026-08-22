using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents data validation.settings.</summary>
public class Validation : LinkElement
{
    /// <summary>Represents the validation alert style.</summary>
    [JsonPropertyName("AlertStyle")]
    public string? AlertStyle { get; set; }

    /// <summary>Represents a collection of Aspose.Cells.CellArea which contains the data</summary>
    [JsonPropertyName("AreaList")]
    public List<CellArea>? AreaList { get; set; }

    /// <summary>Represents the data validation error message.</summary>
    [JsonPropertyName("ErrorMessage")]
    public string? ErrorMessage { get; set; }

    /// <summary>Represents the title of the data-validation error dialog box.</summary>
    [JsonPropertyName("ErrorTitle")]
    public string? ErrorTitle { get; set; }

    /// <summary>Represents the value or expression associated with the data validation.</summary>
    [JsonPropertyName("Formula1")]
    public string? Formula1 { get; set; }

    /// <summary>Represents the value or expression associated with the data validation.</summary>
    [JsonPropertyName("Formula2")]
    public string? Formula2 { get; set; }

    /// <summary>Indicates whether blank values are permitted by the range data validation.</summary>
    [JsonPropertyName("IgnoreBlank")]
    public bool? IgnoreBlank { get; set; }

    /// <summary>Indicates whether data validation displays a drop-down list that contains acceptable values.</summary>
    [JsonPropertyName("InCellDropDown")]
    public bool? InCellDropDown { get; set; }

    /// <summary>Represents the data validation input message.</summary>
    [JsonPropertyName("InputMessage")]
    public string? InputMessage { get; set; }

    /// <summary>Represents the title of the data-validation input dialog box.</summary>
    [JsonPropertyName("InputTitle")]
    public string? InputTitle { get; set; }

    /// <summary>Represents the operator for the data validation.</summary>
    [JsonPropertyName("Operator")]
    public string? Operator { get; set; }

    /// <summary>Indicates whether the data validation error message will be displayed whenever the user enters invalid data.</summary>
    [JsonPropertyName("ShowError")]
    public bool? ShowError { get; set; }

    /// <summary>Indicates whether the data validation input message will be displayed whenever the user selects a cell in the data validation range.</summary>
    [JsonPropertyName("ShowInput")]
    public bool? ShowInput { get; set; }

    /// <summary>Represents the data validation type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Represents the first value associated with the data validation.</summary>
    [JsonPropertyName("Value1")]
    public string? Value1 { get; set; }

    /// <summary>Represents the second value associated with the data validation.</summary>
    [JsonPropertyName("Value2")]
    public string? Value2 { get; set; }

}
