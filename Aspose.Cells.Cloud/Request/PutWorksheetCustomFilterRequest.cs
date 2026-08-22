using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;

namespace Aspose.Cells.Cloud.Request;

/// <summary>Filter a list with custom criteria in the worksheet.</summary>
public class PutWorksheetCustomFilterRequest : IRequestOption
{
    public PutWorksheetCustomFilterRequest(string name, string sheetName, string range, int fieldIndex, string operatorType1, string criteria1)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("name is required", nameof(name));
        Name = name;
        if (string.IsNullOrEmpty(sheetName)) throw new ArgumentException("sheetName is required", nameof(sheetName));
        SheetName = sheetName;
        if (string.IsNullOrEmpty(range)) throw new ArgumentException("range is required", nameof(range));
        Range = range;
        FieldIndex = fieldIndex;
        if (string.IsNullOrEmpty(operatorType1)) throw new ArgumentException("operatorType1 is required", nameof(operatorType1));
        OperatorType1 = operatorType1;
        if (string.IsNullOrEmpty(criteria1)) throw new ArgumentException("criteria1 is required", nameof(criteria1));
        Criteria1 = criteria1;
    }

    public string Name { get; }
    public string SheetName { get; }
    public string Range { get; }
    public int FieldIndex { get; }
    public string OperatorType1 { get; }
    public string Criteria1 { get; }
    public bool? IsAnd { get; set; }
    public string? OperatorType2 { get; set; }
    public string? Criteria2 { get; set; }
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
            "/autoFilter/custom";

    public Dictionary<string, string> GetQueryParameters()
    {
        var query = new Dictionary<string, string>();
        query["range"] = Range;
        query["fieldIndex"] = FieldIndex.ToString();
        query["operatorType1"] = OperatorType1;
        query["criteria1"] = Criteria1;
        if (IsAnd.HasValue) query["isAnd"] = IsAnd.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(OperatorType2)) query["operatorType2"] = OperatorType2;
        if (!string.IsNullOrEmpty(Criteria2)) query["criteria2"] = Criteria2;
        if (MatchBlanks.HasValue) query["matchBlanks"] = MatchBlanks.Value ? "true" : "false";
        if (Refresh.HasValue) query["refresh"] = Refresh.Value ? "true" : "false";
        if (!string.IsNullOrEmpty(Folder)) query["folder"] = Folder;
        if (!string.IsNullOrEmpty(StorageName)) query["storageName"] = StorageName;
        return query;
    }

    public object? GetJsonBody() => null;

    public Dictionary<string, object>? GetMultipartForm() => null;
}
