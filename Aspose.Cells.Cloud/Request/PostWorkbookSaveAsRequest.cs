using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Save an Excel file in various formats.</summary>
public class PostWorkbookSaveAsRequest : IRequestOption
{
    public PostWorkbookSaveAsRequest(string name, string newfilename)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(newfilename)) throw new ArgumentException("newfilename is required", nameof(newfilename));
        Newfilename = newfilename;
    }

    public string Name { get; }
    public string Newfilename { get; }
    public SaveOptions? SaveOptions { get; set; }
    public bool? IsAutoFitRows { get; set; }
    public bool? IsAutoFitColumns { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }
    public string? OutStorageName { get; set; }
    public bool? CheckExcelRestriction { get; set; }
    public string? Region { get; set; }
    public bool? PageWideFitOnPerSheet { get; set; }
    public bool? PageTallFitOnPerSheet { get; set; }
    public bool? OnePagePerSheet { get; set; }
    public string? FontsLocation { get; set; }

    public string GetMethod() => "POST";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/SaveAs";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["newfilename"] = Newfilename;
        if (IsAutoFitRows.HasValue) query["isAutoFitRows"] = IsAutoFitRows.Value ? "true" : "false";
        if (IsAutoFitColumns.HasValue) query["isAutoFitColumns"] = IsAutoFitColumns.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (!string.IsNullOrEmpty(OutStorageName)) query["outStorageName"] = OutStorageName;
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (PageWideFitOnPerSheet.HasValue) query["pageWideFitOnPerSheet"] = PageWideFitOnPerSheet.Value ? "true" : "false";
        if (PageTallFitOnPerSheet.HasValue) query["pageTallFitOnPerSheet"] = PageTallFitOnPerSheet.Value ? "true" : "false";
        if (OnePagePerSheet.HasValue) query["onePagePerSheet"] = OnePagePerSheet.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(FontsLocation)) query["FontsLocation"] = FontsLocation;
        return query;
    }

    public object? GetJsonBody() => SaveOptions;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
