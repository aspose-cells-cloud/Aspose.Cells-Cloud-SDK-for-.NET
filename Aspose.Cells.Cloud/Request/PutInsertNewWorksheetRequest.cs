using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Insert a new worksheet in the workbook.</summary>
public class PutInsertNewWorksheetRequest : IRequestOption
{
    public PutInsertNewWorksheetRequest(string name, string sheetName, int index, string sheettype)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        Index = index;
        if (string.IsNullOrEmpty(sheettype)) throw new ArgumentException("sheettype is required", nameof(sheettype));
        Sheettype = sheettype;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int Index { get; }
    public string Sheettype { get; }
    public string? Newsheetname { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/insert";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["sheetName"] = SheetName;
        query["index"] = Index.ToString();
        query["sheettype"] = Sheettype;
        if (!string.IsNullOrEmpty(Newsheetname)) query["newsheetname"] = Newsheetname;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
