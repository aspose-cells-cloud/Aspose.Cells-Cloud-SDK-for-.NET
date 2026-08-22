using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class SplitterTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public SplitterTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void SplitLocalFile()
    {
        var request = new SplitSpreadsheetRequest("TestData/Book1.xlsx")
        {
            OutFormat = "PDF",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SplitLocalFileToRemoteFolder()
    {
        var request = new SplitSpreadsheetRequest("TestData/Book1.xlsx")
        {
            OutFormat = "PDF",
            OutPath = "TestData/Out",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void SplitFileInRemote()
    {
        var request = new SplitRemoteSpreadsheetRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
            OutFormat = "PDF",
            OutPath = "TestData/Out",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
