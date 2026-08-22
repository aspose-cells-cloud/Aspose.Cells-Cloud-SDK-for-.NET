using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Run tasks.</summary>
public class PostRunTaskRequest : IRequestOption
{
    public PostRunTaskRequest(TaskData taskData)
    {
        if (taskData is null) throw new ArgumentNullException(nameof(taskData));
        TaskData = taskData;
    }

    public TaskData TaskData { get; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/task/runtask";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        return query;
    }

    public object? GetJsonBody() => TaskData;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
