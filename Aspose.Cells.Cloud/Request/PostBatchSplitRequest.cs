using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Batch splitting files that meet specific matching conditions.</summary>
public class PostBatchSplitRequest : IRequestOption
{
    public PostBatchSplitRequest(BatchSplitRequest batchSplitRequest)
    {
        if (batchSplitRequest is null) throw new ArgumentNullException(nameof(batchSplitRequest));
        BatchSplitRequest = batchSplitRequest;
    }

    public BatchSplitRequest BatchSplitRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/batch/split";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => BatchSplitRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
