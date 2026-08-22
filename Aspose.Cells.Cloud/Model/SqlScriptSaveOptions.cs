using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the SqlScriptSaveOptions model.</summary>
public class SqlScriptSaveOptions : SaveOptions
{
    /// <summary>Gets or sets the CheckIfTableExists.</summary>
    [JsonPropertyName("CheckIfTableExists")]
    public bool? CheckIfTableExists { get; set; }

    /// <summary>Gets or sets the ColumnTypeMap.</summary>
    [JsonPropertyName("ColumnTypeMap")]
    public string? ColumnTypeMap { get; set; }

    /// <summary>Gets or sets the CheckAllDataForColumnType.</summary>
    [JsonPropertyName("CheckAllDataForColumnType")]
    public bool? CheckAllDataForColumnType { get; set; }

    /// <summary>Gets or sets the AddBlankLineBetweenRows.</summary>
    [JsonPropertyName("AddBlankLineBetweenRows")]
    public bool? AddBlankLineBetweenRows { get; set; }

    /// <summary>Gets or sets the Separator.</summary>
    [JsonPropertyName("Separator")]
    public string? Separator { get; set; }

    /// <summary>Gets or sets the OperatorType.</summary>
    [JsonPropertyName("OperatorType")]
    public string? OperatorType { get; set; }

    /// <summary>Gets or sets the PrimaryKey.</summary>
    [JsonPropertyName("PrimaryKey")]
    public int? PrimaryKey { get; set; }

    /// <summary>Gets or sets the CreateTable.</summary>
    [JsonPropertyName("CreateTable")]
    public bool? CreateTable { get; set; }

    /// <summary>Gets or sets the IdName.</summary>
    [JsonPropertyName("IdName")]
    public string? IdName { get; set; }

    /// <summary>Gets or sets the StartId.</summary>
    [JsonPropertyName("StartId")]
    public int? StartId { get; set; }

    /// <summary>Gets or sets the TableName.</summary>
    [JsonPropertyName("TableName")]
    public string? TableName { get; set; }

    /// <summary>Gets or sets the ExportAsString.</summary>
    [JsonPropertyName("ExportAsString")]
    public bool? ExportAsString { get; set; }

    /// <summary>Gets or sets the ExportArea.</summary>
    [JsonPropertyName("ExportArea")]
    public CellArea? ExportArea { get; set; }

    /// <summary>Gets or sets the HasHeaderRow.</summary>
    [JsonPropertyName("HasHeaderRow")]
    public bool? HasHeaderRow { get; set; }

}
