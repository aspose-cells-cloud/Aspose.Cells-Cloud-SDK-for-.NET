using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Data deduplication of spreadsheet files is mainly used to eliminate duplicate data in tables and ranges.</summary>
public class PostDataDeduplicationRequest : IRequestOption
{
    public PostDataDeduplicationRequest(DataDeduplicationRequest dataDeduplicationRequest)
    {
        if (dataDeduplicationRequest is null) throw new ArgumentNullException(nameof(dataDeduplicationRequest));
        DataDeduplicationRequest = dataDeduplicationRequest;
    }

    public DataDeduplicationRequest DataDeduplicationRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/datadeduplication";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => DataDeduplicationRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
