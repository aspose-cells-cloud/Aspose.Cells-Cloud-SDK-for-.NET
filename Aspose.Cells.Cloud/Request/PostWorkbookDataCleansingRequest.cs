using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Data cleaning of spreadsheet files is a data management process used to identify, correct, and remove errors, incompleteness, duplicates, or inaccuracies in tables and ranges.</summary>
public class PostWorkbookDataCleansingRequest : IRequestOption
{
    public PostWorkbookDataCleansingRequest(string name, DataCleansing dataCleansing)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (dataCleansing is null) throw new ArgumentNullException(nameof(dataCleansing));
        DataCleansing = dataCleansing;
    }

    public string Name { get; }
    public DataCleansing DataCleansing { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public string? Password { get; set; }
    public string? Region { get; set; }
    public bool? CheckExcelRestriction { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/datacleansing";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        return query;
    }

    public object? GetJsonBody() => DataCleansing;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
