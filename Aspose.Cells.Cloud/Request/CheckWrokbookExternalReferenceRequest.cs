using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Export Excel internal elements or the workbook itself to various format files.</summary>
public class CheckWrokbookExternalReferenceRequest : IRequestOption
{
    public CheckWrokbookExternalReferenceRequest(CheckExternalReferenceOptions checkExternalReferenceOptions)
    {
        if (checkExternalReferenceOptions is null) throw new ArgumentNullException(nameof(checkExternalReferenceOptions));
        CheckExternalReferenceOptions = checkExternalReferenceOptions;
    }

    public CheckExternalReferenceOptions CheckExternalReferenceOptions { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/checkexternalreference";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => CheckExternalReferenceOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
