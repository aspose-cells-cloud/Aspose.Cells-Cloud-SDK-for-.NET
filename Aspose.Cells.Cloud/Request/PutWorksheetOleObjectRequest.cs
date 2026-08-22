using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add an OLE object in the worksheet.</summary>
public class PutWorksheetOleObjectRequest : IRequestOption
{
    public PutWorksheetOleObjectRequest(string name, string sheetName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
    }

    public string Name { get; }
    public string SheetName { get; }
    public int? UpperLeftRow { get; set; }
    public int? UpperLeftColumn { get; set; }
    public int? Height { get; set; }
    public int? Width { get; set; }
    public string? OleFile { get; set; }
    public string? ImageFile { get; set; }
    public string? Folder { get; set; }
    public string? StorageName { get; set; }

    public string GetMethod() => "PUT";

    public Dictionary<string, string> GetHeaderParameters() =>
        new Dictionary<string, string> { ["Content-Type"] = "application/json" };

    public string GetPath() =>
        "/v3.0/cells/" +
            Uri.EscapeDataString(Name) +
            "/worksheets/" +
            Uri.EscapeDataString(SheetName) +
            "/oleobjects";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (UpperLeftRow.HasValue) query["upperLeftRow"] = UpperLeftRow.Value.ToString();
        if (UpperLeftColumn.HasValue) query["upperLeftColumn"] = UpperLeftColumn.Value.ToString();
        if (Height.HasValue) query["height"] = Height.Value.ToString();
        if (Width.HasValue) query["width"] = Width.Value.ToString();
        if (!string.IsNullOrEmpty(OleFile)) query["oleFile"] = OleFile;
        if (!string.IsNullOrEmpty(ImageFile)) query["imageFile"] = ImageFile;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
