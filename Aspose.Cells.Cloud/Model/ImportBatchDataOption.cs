using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the ImportBatchDataOption model.</summary>
public class ImportBatchDataOption : ImportOption
{
    /// <summary>The class has a property named BatchData which is a list of CellValue objects and can be both read and written.</summary>
    [JsonPropertyName("BatchData")]
    public List<CellValue>? BatchData { get; set; }

}
