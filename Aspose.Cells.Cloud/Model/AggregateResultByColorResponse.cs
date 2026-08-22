using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents the AggregateResultByColorResponse model.</summary>
public class AggregateResultByColorResponse : CellsCloudResponse
{
    /// <summary>Gets or sets the AggregateResults.</summary>
    [JsonPropertyName("AggregateResults")]
    public List<AggregateResultByColor>? AggregateResults { get; set; }

}
