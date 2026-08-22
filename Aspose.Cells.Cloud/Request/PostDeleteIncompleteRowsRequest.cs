using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Deleting incomplete rows of spreadsheet files is mainly used to eliminate incomplete rows in tables and ranges.</summary>
public class PostDeleteIncompleteRowsRequest : IRequestOption
{
    public PostDeleteIncompleteRowsRequest(DeleteIncompleteRowsRequest deleteIncompleteRowsRequest)
    {
        if (deleteIncompleteRowsRequest is null) throw new ArgumentNullException(nameof(deleteIncompleteRowsRequest));
        DeleteIncompleteRowsRequest = deleteIncompleteRowsRequest;
    }

    public DeleteIncompleteRowsRequest DeleteIncompleteRowsRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/deleteincompleterows";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => DeleteIncompleteRowsRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
