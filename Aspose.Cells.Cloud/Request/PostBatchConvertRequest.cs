using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Batch converting files that meet specific matching conditions.</summary>
public class PostBatchConvertRequest : IRequestOption
{
    public PostBatchConvertRequest(BatchConvertRequest batchConvertRequest)
    {
        if (batchConvertRequest is null) throw new ArgumentNullException(nameof(batchConvertRequest));
        BatchConvertRequest = batchConvertRequest;
    }

    public BatchConvertRequest BatchConvertRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/batch/convert";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => BatchConvertRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
