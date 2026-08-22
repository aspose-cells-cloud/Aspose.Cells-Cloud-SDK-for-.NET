using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Retrieve a picture by number in the worksheet.</summary>
public class GetWorksheetPictureWithFormatRequest : IRequestOption
{
    public GetWorksheetPictureWithFormatRequest(string name, string sheetName, int pictureNumber, string format)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        PictureNumber = pictureNumber;
        if (string.IsNullOrEmpty(format)) throw new ArgumentException("format is required", nameof(format));
        Format = format;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int PictureNumber { get; }
    public string Format { get; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "GET";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/pictures/" +
            Uri.EscapeDataString(PictureNumber.ToString());

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["format"] = Format;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
