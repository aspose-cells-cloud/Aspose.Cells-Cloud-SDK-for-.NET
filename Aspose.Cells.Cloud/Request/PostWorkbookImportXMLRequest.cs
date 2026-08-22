using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Import an XML data file into an Excel file. The XML data file can either be a cloud file or data from an HTTP URI.</summary>
public class PostWorkbookImportXMLRequest : IRequestOption
{
    public PostWorkbookImportXMLRequest(string name, ImportXMLRequest importXMLRequest)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (importXMLRequest is null) throw new ArgumentNullException(nameof(importXMLRequest));
        ImportXMLRequest = importXMLRequest;
    }

    public string Name { get; }
    public ImportXMLRequest ImportXMLRequest { get; }
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
            "/importxml";

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

    public object? GetJsonBody() => ImportXMLRequest;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
