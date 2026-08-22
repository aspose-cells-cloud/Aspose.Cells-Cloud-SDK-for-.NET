using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class HypelinksControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public HypelinksControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetWorksheetHyperlinks()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetHyperlinksRequest("Book1.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetHyperlink()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetHyperlinkRequest("Book1.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetHyperlink()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetHyperlinkRequest("Book1.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetHyperlink()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetHyperlinkRequest("Book1.xlsx", "Sheet1", 0, new Hyperlink { Address = "https://products.aspose.cloud/cells/" })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetHyperlink()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorksheetHyperlinkRequest("Book1.xlsx", "Sheet1", 1, 1, 2, 3, "https://products.aspose.cloud/cells/")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetHyperlinks()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetHyperlinksRequest("Book1.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
