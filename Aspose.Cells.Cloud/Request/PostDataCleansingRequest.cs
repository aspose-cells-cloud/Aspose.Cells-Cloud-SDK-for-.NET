using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Data cleansing of spreadsheet files is a data management process used to identify, correct, and remove errors, incompleteness, duplicates, or inaccuracies in tables and ranges.</summary>
public class PostDataCleansingRequest : IRequestOption
{
    public PostDataCleansingRequest(DataCleansingRequest dataCleansingRequest)
    {
        if (dataCleansingRequest is null) throw new ArgumentNullException(nameof(dataCleansingRequest));
        DataCleansingRequest = dataCleansingRequest;
    }

    public DataCleansingRequest DataCleansingRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/datacleansing";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => DataCleansingRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
