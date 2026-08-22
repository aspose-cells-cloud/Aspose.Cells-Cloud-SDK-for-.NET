using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Class Summary: The features discussed include natural language processing, image recognition, data visualization, clustering, regression, classification, and recommendation systems.</summary>
public class ProtectSheetParameter
{
    /// <summary>Property Summary: Defines a public string property for the ProtectionType.</summary>
    [JsonPropertyName("ProtectionType")]
    public string? ProtectionType { get; set; }

    /// <summary>Gets or sets the Password.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

    /// <summary>Gets or sets the AllowEditArea.</summary>
    [JsonPropertyName("AllowEditArea")]
    public List<string>? AllowEditArea { get; set; }

    /// <summary>Gets or sets the AllowDeletingColumn.</summary>
    [JsonPropertyName("AllowDeletingColumn")]
    public string? AllowDeletingColumn { get; set; }

    /// <summary>Gets or sets the AllowDeletingRow.</summary>
    [JsonPropertyName("AllowDeletingRow")]
    public string? AllowDeletingRow { get; set; }

    /// <summary>Gets or sets the AllowFiltering.</summary>
    [JsonPropertyName("AllowFiltering")]
    public string? AllowFiltering { get; set; }

    /// <summary>Gets or sets the AllowFormattingCell.</summary>
    [JsonPropertyName("AllowFormattingCell")]
    public string? AllowFormattingCell { get; set; }

    /// <summary>Gets or sets the AllowFormattingColumn.</summary>
    [JsonPropertyName("AllowFormattingColumn")]
    public string? AllowFormattingColumn { get; set; }

    /// <summary>Gets or sets the AllowFormattingRow.</summary>
    [JsonPropertyName("AllowFormattingRow")]
    public string? AllowFormattingRow { get; set; }

    /// <summary>Gets or sets the AllowInsertingColumn.</summary>
    [JsonPropertyName("AllowInsertingColumn")]
    public string? AllowInsertingColumn { get; set; }

    /// <summary>Gets or sets the AllowInsertingHyperlink.</summary>
    [JsonPropertyName("AllowInsertingHyperlink")]
    public string? AllowInsertingHyperlink { get; set; }

    /// <summary>Gets or sets the AllowInsertingRow.</summary>
    [JsonPropertyName("AllowInsertingRow")]
    public string? AllowInsertingRow { get; set; }

    /// <summary>Gets or sets the AllowSelectingLockedCell.</summary>
    [JsonPropertyName("AllowSelectingLockedCell")]
    public string? AllowSelectingLockedCell { get; set; }

    /// <summary>Gets or sets the AllowSelectingUnlockedCell.</summary>
    [JsonPropertyName("AllowSelectingUnlockedCell")]
    public string? AllowSelectingUnlockedCell { get; set; }

    /// <summary>Gets or sets the AllowSorting.</summary>
    [JsonPropertyName("AllowSorting")]
    public string? AllowSorting { get; set; }

    /// <summary>Gets or sets the AllowUsingPivotTable.</summary>
    [JsonPropertyName("AllowUsingPivotTable")]
    public string? AllowUsingPivotTable { get; set; }

}
