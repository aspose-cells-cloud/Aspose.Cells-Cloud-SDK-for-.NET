using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class OleObjectsControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public OleObjectsControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetWorksheetOleObjects()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetOleObjectsRequest("Book1.xlsx", "Sheet6")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetOleObject()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetOleObjectRequest("Book1.xlsx", "Sheet6", 0)
        {
            Format = "png",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void DeleteWorksheetOleObjects()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetOleObjectsRequest("Book1.xlsx", "Sheet6")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetOleObject()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetOleObjectRequest("Book1.xlsx", "Sheet6", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostUpdateWorksheetOleObject()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostUpdateWorksheetOleObjectRequest("Book1.xlsx", "Sheet6", 0, new OleObject { Left = 10, Right = 10, Height = 90, Width = 78 })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetOleObject()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/OLEDoc.docx", "OLEDoc.docx"));
        _client.Do(new UploadFileRequest("testdata/word.jpg", "word.jpg"));
        var request = new PutWorksheetOleObjectRequest("Book1.xlsx", "Sheet6")
        {
            UpperLeftRow = 1,
            UpperLeftColumn = 1,
            Height = 100,
            Width = 80,
            OleFile = "OLEDoc.docx",
            ImageFile = "word.jpg",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
