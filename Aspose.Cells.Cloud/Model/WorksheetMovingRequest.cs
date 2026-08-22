using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Used by workbook moving requests.</summary>
public class WorksheetMovingRequest
{
    /// <summary>Destination worksheet name.</summary>
    [JsonPropertyName("DestinationWorksheet")]
    public string? DestinationWorksheet { get; set; }

    /// <summary>Position to move. Can be BEFORE or AFTER.</summary>
    [JsonPropertyName("Position")]
    public string? Position { get; set; }

}
