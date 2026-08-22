using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Perform business analysis of data in Excel files.</summary>
public class PostAnalyzeExcelRequest : IRequestOption
{
    public PostAnalyzeExcelRequest(AnalyzeExcelRequest analyzeExcelRequest)
    {
        if (analyzeExcelRequest is null) throw new ArgumentNullException(nameof(analyzeExcelRequest));
        AnalyzeExcelRequest = analyzeExcelRequest;
    }

    public AnalyzeExcelRequest AnalyzeExcelRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/analyze";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => AnalyzeExcelRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
