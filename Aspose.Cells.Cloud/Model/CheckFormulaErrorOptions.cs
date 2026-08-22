using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the CheckFormulaErrorOptions model.</summary>
public class CheckFormulaErrorOptions
{
    /// <summary>Gets or sets the DataSource.</summary>
    [JsonPropertyName("DataSource")]
    public DataSource? DataSource { get; set; }

    /// <summary>Gets or sets the FileInfo.</summary>
    [JsonPropertyName("FileInfo")]
    public FileInfo? FileInfo { get; set; }

    /// <summary>Gets or sets the SheetName.</summary>
    [JsonPropertyName("SheetName")]
    public string? SheetName { get; set; }

    /// <summary>Gets or sets the ChartIndex.</summary>
    [JsonPropertyName("ChartIndex")]
    public int? ChartIndex { get; set; }

    /// <summary>Gets or sets the Names.</summary>
    [JsonPropertyName("Names")]
    public List<string>? Names { get; set; }

}
