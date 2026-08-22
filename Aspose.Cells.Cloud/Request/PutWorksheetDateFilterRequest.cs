using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Apply a date filter in the worksheet.</summary>
public class PutWorksheetDateFilterRequest : IRequestOption
{
    public PutWorksheetDateFilterRequest(string name, string sheetName, string range, int fieldIndex, string dateTimeGroupingType)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        FieldIndex = fieldIndex;
        if (string.IsNullOrEmpty(dateTimeGroupingType)) throw new ArgumentException("dateTimeGroupingType is required", nameof(dateTimeGroupingType));
        DateTimeGroupingType = dateTimeGroupingType;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string Range { get; }
    public int FieldIndex { get; }
    public string DateTimeGroupingType { get; }
    public int? Year { get; set; }
    public int? Month { get; set; }
    public int? Day { get; set; }
    public int? Hour { get; set; }
    public int? Minute { get; set; }
    public int? Second { get; set; }
    public bool? MatchBlanks { get; set; }
    public bool? Refresh { get; set; }
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
            "/autoFilter/dateFilter";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["range"] = Range;
        query["fieldIndex"] = FieldIndex.ToString();
        query["dateTimeGroupingType"] = DateTimeGroupingType;
        if (Year.HasValue) query["year"] = Year.Value.ToString();
        if (Month.HasValue) query["month"] = Month.Value.ToString();
        if (Day.HasValue) query["day"] = Day.Value.ToString();
        if (Hour.HasValue) query["hour"] = Hour.Value.ToString();
        if (Minute.HasValue) query["minute"] = Minute.Value.ToString();
        if (Second.HasValue) query["second"] = Second.Value.ToString();
        if (MatchBlanks.HasValue) query["matchBlanks"] = MatchBlanks.Value ? "true" : "false";
        if (Refresh.HasValue) query["refresh"] = Refresh.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
