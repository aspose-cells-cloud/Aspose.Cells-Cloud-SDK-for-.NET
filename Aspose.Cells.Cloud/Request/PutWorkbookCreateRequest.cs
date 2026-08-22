using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Create a new workbook using different methods.</summary>
public class PutWorkbookCreateRequest : IRequestOption
{
    public PutWorkbookCreateRequest(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
    }

    public string Name { get; }
    public string? TemplateFile { get; set; }
    public string? DataFile { get; set; }
    public bool? IsWriteOver { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public bool? CheckExcelRestriction { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(TemplateFile)) query["templateFile"] = TemplateFile;
        if (!string.IsNullOrEmpty(DataFile)) query["dataFile"] = DataFile;
        if (IsWriteOver.HasValue) query["isWriteOver"] = IsWriteOver.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
