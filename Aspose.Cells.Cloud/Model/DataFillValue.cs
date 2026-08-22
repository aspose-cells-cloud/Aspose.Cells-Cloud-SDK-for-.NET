using System.Text.Json.Serialization;

namespace Aspose.Cells.Cloud.Model;

/// <summary>Represents that the data is populated with the specified value.</summary>
public class DataFillValue
{
    /// <summary>Represents default bool value.</summary>
    [JsonPropertyName("DefaultBoolean")]
    public bool? DefaultBoolean { get; set; }

    /// <summary>Represents default string value.</summary>
    [JsonPropertyName("DefaultString")]
    public string? DefaultString { get; set; }

    /// <summary>Represents default number value.</summary>
    [JsonPropertyName("DefaultNumber")]
    public int? DefaultNumber { get; set; }

    /// <summary>Represents default double value.</summary>
    [JsonPropertyName("DefaultDouble")]
    public double? DefaultDouble { get; set; }

    /// <summary>Represents default date value.</summary>
    [JsonPropertyName("DefaultDate")]
    public string? DefaultDate { get; set; }

}
