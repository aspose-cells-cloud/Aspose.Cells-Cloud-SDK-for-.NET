using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Batch locking files that meet specific matching conditions.</summary>
public class PostBatchLockRequest : IRequestOption
{
    public PostBatchLockRequest(BatchLockRequest batchLockRequest)
    {
        if (batchLockRequest is null) throw new ArgumentNullException(nameof(batchLockRequest));
        BatchLockRequest = batchLockRequest;
    }

    public BatchLockRequest BatchLockRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/batch/lock";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => BatchLockRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
