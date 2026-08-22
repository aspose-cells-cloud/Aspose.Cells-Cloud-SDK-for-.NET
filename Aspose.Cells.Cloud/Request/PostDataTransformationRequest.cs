using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Transform spreadsheet data is mainly used to pivot columns, unpivot columns.</summary>
public class PostDataTransformationRequest : IRequestOption
{
    public PostDataTransformationRequest(DataTransformationRequest dataTransformationRequest)
    {
        if (dataTransformationRequest is null) throw new ArgumentNullException(nameof(dataTransformationRequest));
        DataTransformationRequest = dataTransformationRequest;
    }

    public DataTransformationRequest DataTransformationRequest { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/datatransformation";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => DataTransformationRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
