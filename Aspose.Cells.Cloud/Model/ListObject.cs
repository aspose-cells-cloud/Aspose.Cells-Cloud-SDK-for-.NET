using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents a list object on a worksheet.            The ListObject object is a member of the ListObjects collection.             The ListObjects collection contains all the list objects on a worksheet.</summary>
public class ListObject : LinkElement
{
    /// <summary>Gets auto filter.</summary>
    [JsonPropertyName("AutoFilter")]
    public AutoFilter? AutoFilter { get; set; }

    /// <summary>Gets and sets the display name.</summary>
    [JsonPropertyName("DisplayName")]
    public string? DisplayName { get; set; }

    /// <summary>Gets the start column of the range.</summary>
    [JsonPropertyName("StartColumn")]
    public int? StartColumn { get; set; }

    /// <summary>Gets the start row of the range.</summary>
    [JsonPropertyName("StartRow")]
    public int? StartRow { get; set; }

    /// <summary>Gets the end column of the range.</summary>
    [JsonPropertyName("EndColumn")]
    public int? EndColumn { get; set; }

    /// <summary>Gets the end  row of the range.</summary>
    [JsonPropertyName("EndRow")]
    public int? EndRow { get; set; }

    /// <summary>Gets ListColumns of the ListObject.</summary>
    [JsonPropertyName("ListColumns")]
    public List<ListColumn>? ListColumns { get; set; }

    /// <summary>Gets and sets whether this ListObject show header row.</summary>
    [JsonPropertyName("ShowHeaderRow")]
    public bool? ShowHeaderRow { get; set; }

    /// <summary>Indicates whether column stripe formatting is applied.</summary>
    [JsonPropertyName("ShowTableStyleColumnStripes")]
    public bool? ShowTableStyleColumnStripes { get; set; }

    /// <summary>Indicates whether the first column in the table should have the style applied.</summary>
    [JsonPropertyName("ShowTableStyleFirstColumn")]
    public bool? ShowTableStyleFirstColumn { get; set; }

    /// <summary>Indicates whether the last column in the table should have the style applied.</summary>
    [JsonPropertyName("ShowTableStyleLastColumn")]
    public bool? ShowTableStyleLastColumn { get; set; }

    /// <summary>Indicates whether row stripe formatting is applied.</summary>
    [JsonPropertyName("ShowTableStyleRowStripes")]
    public bool? ShowTableStyleRowStripes { get; set; }

    /// <summary>Gets and sets whether this ListObject show total row.</summary>
    [JsonPropertyName("ShowTotals")]
    public bool? ShowTotals { get; set; }

    /// <summary>Gets and sets the table style name.</summary>
    [JsonPropertyName("TableStyleName")]
    public string? TableStyleName { get; set; }

    /// <summary>Gets and the built-in table style.</summary>
    [JsonPropertyName("TableStyleType")]
    public string? TableStyleType { get; set; }

    /// <summary>Gets the data range of the ListObject.</summary>
    [JsonPropertyName("DataRange")]
    public Range? DataRange { get; set; }

    /// <summary>Gets the data source type of the table.</summary>
    [JsonPropertyName("DataSourceType")]
    public string? DataSourceType { get; set; }

    /// <summary>Gets and sets the comment of the table.</summary>
    [JsonPropertyName("Comment")]
    public string? Comment { get; set; }

    /// <summary>Gets an  used for this list.</summary>
    [JsonPropertyName("XmlMap")]
    public XmlMap? XmlMap { get; set; }

    /// <summary>Gets and sets the alternative text.</summary>
    [JsonPropertyName("AlternativeText")]
    public string? AlternativeText { get; set; }

    /// <summary>Gets and sets the alternative description.</summary>
    [JsonPropertyName("AlternativeDescription")]
    public string? AlternativeDescription { get; set; }

}
