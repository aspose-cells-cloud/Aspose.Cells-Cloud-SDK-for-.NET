using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Data filling for spreadsheet files is primarily used to fill empty data in tables and ranges.</summary>
public class PostWorkbookDataFillRequest : IRequestOption
{
    public PostWorkbookDataFillRequest(string name, DataFill dataFill)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (dataFill is null) throw new ArgumentNullException(nameof(dataFill));
        DataFill = dataFill;
    }

    public string Name { get; }
    public DataFill DataFill { get; }
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
            "/datafill";

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

    public object? GetJsonBody() => DataFill;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
