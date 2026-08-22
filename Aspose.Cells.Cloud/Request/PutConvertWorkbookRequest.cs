using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Convert the workbook from the requested content into files in different formats.</summary>
public class PutConvertWorkbookRequest : IRequestOption
{
    public PutConvertWorkbookRequest(FileParameter file, string format)
    {
        if (file is null) throw new ArgumentNullException(nameof(file));
        File = file;
        if (string.IsNullOrEmpty(format)) throw new ArgumentException("format is required", nameof(format));
        Format = format;
    }

    public FileParameter File { get; }
    public string Format { get; }
    public string? Password { get; set; }
    public string? OutPath { get; set; }
    public string? StorageName { get; set; }
    public bool? CheckExcelRestriction { get; set; }
    public string? StreamFormat { get; set; }
    public string? Region { get; set; }
    public bool? PageWideFitOnPerSheet { get; set; }
    public bool? PageTallFitOnPerSheet { get; set; }
    public string? SheetName { get; set; }
    public int? PageIndex { get; set; }
    public bool? OnePagePerSheet { get; set; }
    public bool? AutoRowsFit { get; set; }
    public bool? AutoColumnsFit { get; set; }
    public string? FontsLocation { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "multipart/form-data" };

    public string GetPath() =>
        "/v3.0/cells/convert";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["format"] = Format;
        if (!string.IsNullOrEmpty(Password)) query["password"] = Password;
        if (!string.IsNullOrEmpty(OutPath)) query["outPath"] = OutPath;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        if (CheckExcelRestriction.HasValue) query["checkExcelRestriction"] = CheckExcelRestriction.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(StreamFormat)) query["streamFormat"] = StreamFormat;
        if (!string.IsNullOrEmpty(Region)) query["region"] = Region;
        if (PageWideFitOnPerSheet.HasValue) query["pageWideFitOnPerSheet"] = PageWideFitOnPerSheet.Value ? "true" : "false";
        if (PageTallFitOnPerSheet.HasValue) query["pageTallFitOnPerSheet"] = PageTallFitOnPerSheet.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(SheetName)) query["sheetName"] = SheetName;
        if (PageIndex.HasValue) query["pageIndex"] = PageIndex.Value.ToString();
        if (OnePagePerSheet.HasValue) query["onePagePerSheet"] = OnePagePerSheet.Value ? "true" : "false";
        if (AutoRowsFit.HasValue) query["AutoRowsFit"] = AutoRowsFit.Value ? "true" : "false";
        if (AutoColumnsFit.HasValue) query["AutoColumnsFit"] = AutoColumnsFit.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(FontsLocation)) query["FontsLocation"] = FontsLocation;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() =>
        new Dictionary<string, object>
        {
            ["@" + File.FileName] = File,
        };
}
