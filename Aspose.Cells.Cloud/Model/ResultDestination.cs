using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents result destination.</summary>
public class ResultDestination
{
    /// <summary>Represents destination data type.</summary>
    [JsonPropertyName("DestinationType")]
    public string? DestinationType { get; set; }

    /// <summary>Represents input file.</summary>
    [JsonPropertyName("InputFile")]
    public string? InputFile { get; set; }

    /// <summary>Represents output file.</summary>
    [JsonPropertyName("OutputFile")]
    public string? OutputFile { get; set; }

}
