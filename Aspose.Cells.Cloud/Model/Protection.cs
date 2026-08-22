using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the various types of protection options available for a worksheet.</summary>
public class Protection
{
    /// <summary>Represents if the deletion of columns is allowed on a protected worksheet.</summary>
    [JsonPropertyName("AllowDeletingColumn")]
    public bool? AllowDeletingColumn { get; set; }

    /// <summary>Represents if the deletion of rows is allowed on a protected worksheet.</summary>
    [JsonPropertyName("AllowDeletingRow")]
    public bool? AllowDeletingRow { get; set; }

    /// <summary>Represents if the user is allowed to make use of an AutoFilter that was created before the sheet was protected.</summary>
    [JsonPropertyName("AllowFiltering")]
    public bool? AllowFiltering { get; set; }

    /// <summary>Represents if the formatting of cells is allowed on a protected worksheet.</summary>
    [JsonPropertyName("AllowFormattingCell")]
    public bool? AllowFormattingCell { get; set; }

    /// <summary>Represents if the formatting of columns is allowed on a protected worksheet</summary>
    [JsonPropertyName("AllowFormattingColumn")]
    public bool? AllowFormattingColumn { get; set; }

    /// <summary>Represents if the formatting of rows is allowed on a protected worksheet</summary>
    [JsonPropertyName("AllowFormattingRow")]
    public bool? AllowFormattingRow { get; set; }

    /// <summary>Represents if the insertion of columns is allowed on a protected worksheet</summary>
    [JsonPropertyName("AllowInsertingColumn")]
    public bool? AllowInsertingColumn { get; set; }

    /// <summary>Represents if the insertion of hyperlinks is allowed on a protected worksheet</summary>
    [JsonPropertyName("AllowInsertingHyperlink")]
    public bool? AllowInsertingHyperlink { get; set; }

    /// <summary>Represents if the insertion of rows is allowed on a protected worksheet</summary>
    [JsonPropertyName("AllowInsertingRow")]
    public bool? AllowInsertingRow { get; set; }

    /// <summary>Represents if the sorting option is allowed on a protected worksheet.</summary>
    [JsonPropertyName("AllowSorting")]
    public bool? AllowSorting { get; set; }

    /// <summary>Represents if the user is allowed to manipulate pivot tables on a protected worksheet.</summary>
    [JsonPropertyName("AllowUsingPivotTable")]
    public bool? AllowUsingPivotTable { get; set; }

    /// <summary>Represents if the user is allowed to edit contents of locked cells on a protected worksheet.</summary>
    [JsonPropertyName("AllowEditingContent")]
    public bool? AllowEditingContent { get; set; }

    /// <summary>Represents if the user is allowed to manipulate drawing objects on a protected worksheet.</summary>
    [JsonPropertyName("AllowEditingObject")]
    public bool? AllowEditingObject { get; set; }

    /// <summary>Represents if the user is allowed to edit scenarios on a protected worksheet.</summary>
    [JsonPropertyName("AllowEditingScenario")]
    public bool? AllowEditingScenario { get; set; }

    /// <summary>Represents the password to protect the worksheet.</summary>
    [JsonPropertyName("Password")]
    public string? Password { get; set; }

    /// <summary>Represents if the user is allowed to select locked cells on a protected worksheet.</summary>
    [JsonPropertyName("AllowSelectingLockedCell")]
    public bool? AllowSelectingLockedCell { get; set; }

    /// <summary>Represents if the user is allowed to select unlocked cells on a protected worksheet.</summary>
    [JsonPropertyName("AllowSelectingUnlockedCell")]
    public bool? AllowSelectingUnlockedCell { get; set; }

}
