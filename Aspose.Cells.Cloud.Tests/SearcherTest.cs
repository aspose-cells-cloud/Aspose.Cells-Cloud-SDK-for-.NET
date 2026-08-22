using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class SearcherTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public SearcherTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void SearchTextInLocalFile()
    {
        var request = new SearchSpreadsheetContentRequest("TestData/BookText.xlsx", "Bike")
        {
            IgnoringCase = false,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchTextFromWorksheetInLocalFile()
    {
        var request = new SearchSpreadsheetContentRequest("TestData/BookText.xlsx", "Bike")
        {
            IgnoringCase = false,
            Worksheet = "Sales",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchTextInRemoteSpreadsheet()
    {
        _client.Do(new UploadFileRequest("testdata/BookText.xlsx", "TestData/In/BookText.xlsx"));
        var request = new SearchContentInRemoteSpreadsheetRequest("BookText.xlsx", "Bike")
        {
            IgnoringCase = false,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchTextInRemoteRange()
    {
        _client.Do(new UploadFileRequest("testdata/BookText.xlsx", "TestData/In/BookText.xlsx"));
        var request = new SearchContentInRemoteRangeRequest("BookText.xlsx", "Sales", "A1:A10", "Bike")
        {
            IgnoringCase = false,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchSpreadsheetBrokenLinks()
    {
        var request = new SearchSpreadsheetBrokenLinksRequest("TestData/BookFormula.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchBrokenLinksInRemoteSpreadsheet()
    {
        _client.Do(new UploadFileRequest("testdata/BookFormula.xlsx", "TestData/In/BookFormula.xlsx"));
        var request = new SearchBrokenLinksInRemoteSpreadsheetRequest("BookFormula.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchBrokenLinksInRemoteWorksheet()
    {
        _client.Do(new UploadFileRequest("testdata/BookFormula.xlsx", "TestData/In/BookFormula.xlsx"));
        var request = new SearchBrokenLinksInRemoteWorksheetRequest("BookFormula.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchBrokenLinksInRemoteRange()
    {
        _client.Do(new UploadFileRequest("testdata/BookFormula.xlsx", "TestData/In/BookFormula.xlsx"));
        var request = new SearchBrokenLinksInRemoteRangeRequest("BookFormula.xlsx", "Sheet1", "A1:F40")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchAllTextItemsInRemoteSpreadsheet()
    {
        _client.Do(new UploadFileRequest("testdata/BookFormula.xlsx", "TestData/In/BookFormula.xlsx"));
        var request = new SearchAllTextItemsInRemoteSpreadsheetRequest("BookFormula.xlsx", "TestData/In");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SearchSpreadsheetAllTextItems()
    {
        var request = new SearchSpreadsheetAllTextItemsRequest("TestData/EmployeeSalesSummary.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
