using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Effortlessly extract text and numbers from Excel cells with precise options. This API allows extraction of first/last characters, text between delimiters, and numbers from strings, with output as static values or formulas.</summary>
public class PostExtractTextRequest : IRequestOption
{
    public PostExtractTextRequest(ExtractTextOptions extractTextOptions)
    {
        if (extractTextOptions is null) throw new ArgumentNullException(nameof(extractTextOptions));
        ExtractTextOptions = extractTextOptions;
    }

    public ExtractTextOptions ExtractTextOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/extracttext";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => ExtractTextOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
