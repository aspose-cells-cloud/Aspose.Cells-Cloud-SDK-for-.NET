using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Batch protecting files that meet specific matching conditions.</summary>
public class PostBatchProtectRequest : IRequestOption
{
    public PostBatchProtectRequest(BatchProtectRequest batchProtectRequest)
    {
        if (batchProtectRequest is null) throw new ArgumentNullException(nameof(batchProtectRequest));
        BatchProtectRequest = batchProtectRequest;
    }

    public BatchProtectRequest BatchProtectRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/batch/protect";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => BatchProtectRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
