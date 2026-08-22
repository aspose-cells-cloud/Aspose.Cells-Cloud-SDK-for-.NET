using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Add a new picture in the worksheet.</summary>
public class PutWorksheetAddPictureRequest : IRequestOption
{
    public PutWorksheetAddPictureRequest(string name, string sheetName)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
    }

    public string Name { get; }
    public string SheetName { get; }
    public Picture? Picture { get; set; }
    public int? UpperLeftRow { get; set; }
    public int? UpperLeftColumn { get; set; }
    public int? LowerRightRow { get; set; }
    public int? LowerRightColumn { get; set; }
    public string? PicturePath { get; set; }
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
            "/pictures";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        if (UpperLeftRow.HasValue) query["upperLeftRow"] = UpperLeftRow.Value.ToString();
        if (UpperLeftColumn.HasValue) query["upperLeftColumn"] = UpperLeftColumn.Value.ToString();
        if (LowerRightRow.HasValue) query["lowerRightRow"] = LowerRightRow.Value.ToString();
        if (LowerRightColumn.HasValue) query["lowerRightColumn"] = LowerRightColumn.Value.ToString();
        if (!string.IsNullOrEmpty(PicturePath)) query["picturePath"] = PicturePath;
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => Picture;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
