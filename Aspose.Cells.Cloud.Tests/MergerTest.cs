using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class MergerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public MergerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    // Skipped: unknown API method MergeRemoteSpreadsheets

    [Fact]
    public void MergeRemoteSpreadsheet()
    {
        _client.Do(new UploadFileRequest("testdata/BookText.xlsx", "TestData/In/BookText.xlsx"));
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new MergeRemoteSpreadsheetRequest("BookText.xlsx", "TestData/In/Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
