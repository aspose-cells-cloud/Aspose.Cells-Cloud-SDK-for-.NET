using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>AI task decomposition: Convert user objectives to sequential action plans with formatted file export.</summary>
public class DecomposeUserTaskRequest : IRequestOption
{
    public DecomposeUserTaskRequest(string taskDescription)
    {
        if (string.IsNullOrEmpty(taskDescription)) throw new ArgumentException("TaskDescription is required", nameof(taskDescription));
        TaskDescription = taskDescription;
    }

    public string TaskDescription { get; }
    public string? Region { get; set; }
    public string? Password { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v4.0/cells/ai/task/decompose";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        return query;
    }

    public object? GetJsonBody() => TaskDescription;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
