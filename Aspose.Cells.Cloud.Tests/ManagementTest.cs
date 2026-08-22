using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ManagementTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ManagementTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void CreateSpreadsheet()
    {
        var request = new CreateSpreadsheetRequest()
        {
            Format = "xlsx",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void CreateSpreadsheetWithTemplate()
    {
        var request = new CreateSpreadsheetRequest()
        {
            Format = "pdf",
            Template = "SalesDataComparisonXLSX",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void AddWorksheet()
    {
        var request = new AddWorksheetToSpreadsheetRequest("TestData/AggregateCellsByColor.xlsx")
        {
            SheetType = "Worksheet",
            Position = 1,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void DeleteWorksheet()
    {
        var request = new DeleteWorksheetFromSpreadsheetRequest("TestData/EmployeeSalesSummary.xlsx", "Sales");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void RenameWorksheet()
    {
        var request = new RenameWorksheetInSpreadsheetRequest("TestData/EmployeeSalesSummary.xlsx", "Sales", "SalesData");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void MoveWorksheet()
    {
        var request = new MoveWorksheetInSpreadsheetRequest("TestData/EmployeeSalesSummary.xlsx", "Sales", 1);
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void CompressSpreadsheet()
    {
        var request = new CompressSpreadsheetRequest("TestData/EmployeeSalesSummary.xlsx", 9);
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void RepairSpreadsheet()
    {
        var request = new RepairSpreadsheetRequest("TestData/EmployeeSalesSummary.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    // Skipped: unknown API method GetWorksheetsWithSpreadsheet

    [Fact]
    public void GetMergedCellsInRemotedWorksheet()
    {
        _client.Do(new UploadFileRequest("testdata/EmployeeSalesSummary.xlsx", "TestData/In/EmployeeSalesSummary.xlsx"));
        var request = new GetMergedCellsInRemotedWorksheetRequest("EmployeeSalesSummary.xlsx", "Sales")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetMergedCellsInWorksheet()
    {
        var request = new GetMergedCellsInWorksheetRequest("TestData/EmployeeSalesSummary.xlsx", "Sales");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
