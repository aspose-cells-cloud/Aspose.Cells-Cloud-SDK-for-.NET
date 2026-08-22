using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class TransformTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public TransformTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void RemoveSpreadsheetBlankRows()
    {
        var request = new RemoveSpreadsheetBlankRowsRequest("TestData/EmployeeSalesSummary.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void RemoveSpreadsheetBlankColumns()
    {
        var request = new RemoveSpreadsheetBlankColumnsRequest("TestData/EmployeeSalesSummary.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void RemoveSpreadsheetBlankWorksheets()
    {
        var request = new RemoveSpreadsheetBlankWorksheetsRequest("TestData/EmployeeSalesSummary-BlankWorksheet.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    // Skipped: unknown API method SawpRange

    public void Dispose() { }
}
