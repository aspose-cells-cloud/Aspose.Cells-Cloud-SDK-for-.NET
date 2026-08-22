using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>CheckWorkbookFormulaErrors operation.</summary>
public class CheckWorkbookFormulaErrorsRequest : IRequestOption
{
    public CheckWorkbookFormulaErrorsRequest(CheckFormulaErrorOptions formulaErrorOptions)
    {
        if (formulaErrorOptions is null) throw new ArgumentNullException(nameof(formulaErrorOptions));
        FormulaErrorOptions = formulaErrorOptions;
    }

    public CheckFormulaErrorOptions FormulaErrorOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/checkformulaerrors";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => FormulaErrorOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
