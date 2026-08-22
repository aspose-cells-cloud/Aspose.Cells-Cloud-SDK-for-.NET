using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>ReportAIAnalysis operation.</summary>
public class ReportAIAnalysisRequest : IRequestOption
{
    public ReportAIAnalysisRequest(FileParameter spreadsheet)
    {
        if (spreadsheet is null) throw new ArgumentNullException(nameof(spreadsheet));
        Spreadsheet = spreadsheet;
    }

    public FileParameter Spreadsheet { get; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v4.0/cells/ai/report/analysis";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + Spreadsheet.FileName] = Spreadsheet,
        };
}
