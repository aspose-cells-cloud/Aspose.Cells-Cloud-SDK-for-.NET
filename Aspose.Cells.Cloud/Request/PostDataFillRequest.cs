using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Data filling for spreadsheet files is primarily used to fill empty data in tables and ranges.</summary>
public class PostDataFillRequest : IRequestOption
{
    public PostDataFillRequest(DataFillRequest dataFillRequest)
    {
        if (dataFillRequest is null) throw new ArgumentNullException(nameof(dataFillRequest));
        DataFillRequest = dataFillRequest;
    }

    public DataFillRequest DataFillRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/datafill";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => DataFillRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
