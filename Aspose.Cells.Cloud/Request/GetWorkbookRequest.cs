using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Retrieve workbooks in various formats.</summary>
public class GetWorkbookRequest : IRequestOption
{
    public GetWorkbookRequest(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
    }

    public string Name { get; }
    public string? Format { get; set; }
    public string? Password { get; set; }
    public bool? IsAutoFit { get; set; }
    public bool? OnlySaveTable { get; set; }
    public string? Folder { get; set; }
    public string? OutPath { get; set; }
    public string? StorageName { get; set; }
    public string? OutStorageName { get; set; }
    public bool? CheckExcelRestriction { get; set; }
    public string? Region { get; set; }
    public bool? PageWideFitOnPerSheet { get; set; }
    public bool? PageTallFitOnPerSheet { get; set; }
    public bool? OnePagePerSheet { get; set; }
    public bool? OnlyAutofitTable { get; set; }
    public string? FontsLocation { get; set; }

    public string GetMethod() => "GET";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name);

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (!string.IsNullOrEmpty(Format)) query["format"] = Format;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        if (IsAutoFit.HasValue) query["isAutoFit"] = IsAutoFit.Value ? "true" : "false";
        if (OnlySaveTable.HasValue) query["onlySaveTable"] = OnlySaveTable.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (PageWideFitOnPerSheet.HasValue) query["pageWideFitOnPerSheet"] = PageWideFitOnPerSheet.Value ? "true" : "false";
        if (PageTallFitOnPerSheet.HasValue) query["pageTallFitOnPerSheet"] = PageTallFitOnPerSheet.Value ? "true" : "false";
        if (OnePagePerSheet.HasValue) query["onePagePerSheet"] = OnePagePerSheet.Value ? "true" : "false";
        if (OnlyAutofitTable.HasValue) query["onlyAutofitTable"] = OnlyAutofitTable.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(FontsLocation)) query["FontsLocation"] = FontsLocation;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
