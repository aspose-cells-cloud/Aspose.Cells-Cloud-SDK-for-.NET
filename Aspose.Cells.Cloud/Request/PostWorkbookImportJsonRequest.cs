using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Import a JSON data file into the workbook. The JSON data file can either be a cloud file or data from an HTTP URI.</summary>
public class PostWorkbookImportJsonRequest : IRequestOption
{
    public PostWorkbookImportJsonRequest(string name, ImportJsonRequest importJsonRequest)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (importJsonRequest is null) throw new ArgumentNullException(nameof(importJsonRequest));
        ImportJsonRequest = importJsonRequest;
    }

    public string Name { get; }
    public ImportJsonRequest ImportJsonRequest { get; }
    public string? Password { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public string? OutPath { get; set; }
    public string? OutStorageName { get; set; }
    public bool? CheckExcelRestriction { get; set; }
    public string? Region { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/importjson";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        return query;
    }

    public object? GetJsonBody() => ImportJsonRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
