using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Aspose.Cells.Cloud.Model;

/// <summary>- Features: Active class participation, group projects, quizzes, and final exam.</summary>
public class SeriesItems : LinkElement
{
    /// <summary>This property allows setting and getting data for the category.</summary>
    [JsonPropertyName("CategoryData")]
    public string? CategoryData { get; set; }

    /// <summary>Gets or sets the IsColorVaried.</summary>
    [JsonPropertyName("IsColorVaried")]
    public bool? IsColorVaried { get; set; }

    /// <summary>Gets or sets the SecondCatergoryData.</summary>
    [JsonPropertyName("SecondCatergoryData")]
    public string? SecondCatergoryData { get; set; }

    /// <summary>Gets or sets the SeriesList.</summary>
    [JsonPropertyName("SeriesList")]
    public List<Series>? SeriesList { get; set; }

}
