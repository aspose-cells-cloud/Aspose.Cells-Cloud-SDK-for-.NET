using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Encapsulates the object that represents a single Workbook cell.</summary>
public class Cell : LinkElement
{
    /// <summary>Gets the name of the cell.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets row number (zero based) of the cell.</summary>
    [JsonPropertyName("Row")]
    public int? Row { get; set; }

    /// <summary>Gets column number (zero based) of the cell.</summary>
    [JsonPropertyName("Column")]
    public int? Column { get; set; }

    /// <summary>Gets the value contained in this cell.</summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

    /// <summary>Represents cell value type.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets a formula of the .</summary>
    [JsonPropertyName("Formula")]
    public string? Formula { get; set; }

    /// <summary>Represents if the specified cell contains formula.</summary>
    [JsonPropertyName("IsFormula")]
    public bool? IsFormula { get; set; }

    /// <summary>Checks if a cell is part of a merged range or not.</summary>
    [JsonPropertyName("IsMerged")]
    public bool? IsMerged { get; set; }

    /// <summary>Indicates the cell's formula is and array formula</summary>
    [JsonPropertyName("IsArrayHeader")]
    public bool? IsArrayHeader { get; set; }

    /// <summary>Indicates whether the cell formula is an array formula.</summary>
    [JsonPropertyName("IsInArray")]
    public bool? IsInArray { get; set; }

    /// <summary>Checks if the value of this cell is an error.</summary>
    [JsonPropertyName("IsErrorValue")]
    public bool? IsErrorValue { get; set; }

    /// <summary>Indicates whether this cell is part of table formula.</summary>
    [JsonPropertyName("IsInTable")]
    public bool? IsInTable { get; set; }

    /// <summary>Indicates if the cell's style is set. If return false, it means this cell has a default cell format.</summary>
    [JsonPropertyName("IsStyleSet")]
    public bool? IsStyleSet { get; set; }

    /// <summary>Gets and sets the html string which contains data and some formats in this cell.</summary>
    [JsonPropertyName("HtmlString")]
    public string? HtmlString { get; set; }

    /// <summary>This class property represents a style element with the specified XML element name.</summary>
    [JsonPropertyName("Style")]
    public LinkElement? Style { get; set; }

    /// <summary>Gets the parent worksheet.</summary>
    [JsonPropertyName("Worksheet")]
    public string? Worksheet { get; set; }

}
