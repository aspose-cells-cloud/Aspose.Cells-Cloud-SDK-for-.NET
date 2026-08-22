using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Autofit rows in the workbook.</summary>
public class PostAutofitWorkbookRowsRequest : IRequestOption
{
    public PostAutofitWorkbookRowsRequest(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
    }

    public string Name { get; }
    public int? StartRow { get; set; }
    public int? EndRow { get; set; }
    public bool? OnlyAuto { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public int? FirstColumn { get; set; }
    public int? LastColumn { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/autofitrows";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (StartRow.HasValue) query["startRow"] = StartRow.Value.ToString();
        if (EndRow.HasValue) query["endRow"] = EndRow.Value.ToString();
        if (OnlyAuto.HasValue) query["onlyAuto"] = OnlyAuto.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (FirstColumn.HasValue) query["firstColumn"] = FirstColumn.Value.ToString();
        if (LastColumn.HasValue) query["lastColumn"] = LastColumn.Value.ToString();
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
