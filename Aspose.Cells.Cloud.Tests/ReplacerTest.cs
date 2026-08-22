using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ReplacerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ReplacerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void ReplaceTextInLocalFile()
    {
        var request = new ReplaceSpreadsheetContentRequest("TestData/BookText.xlsx", "Bike", "****");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ReplaceTextFromWorksheetInLocalFile()
    {
        var request = new ReplaceSpreadsheetContentRequest("TestData/BookText.xlsx", "Bike", "****")
        {
            Worksheet = "Sales",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    // Skipped: unknown API method ReplaceRemoteSpreadsheetContent

    // Skipped: unknown API method ReplaceRemoteSpreadsheetContent

    [Fact]
    public void ReplaceTextInRemoteRange()
    {
        _client.Do(new UploadFileRequest("testdata/BookText.xlsx", "TestData/In/BookText.xlsx"));
        var request = new ReplaceContentInRemoteRangeRequest("BookText.xlsx", "Bike", "****", "Sales", "A1:A10")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
