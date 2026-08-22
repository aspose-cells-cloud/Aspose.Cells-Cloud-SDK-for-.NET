using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ShapesControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ShapesControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetWorksheetShapes()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetShapesRequest("Book1.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetShape()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetShapeRequest("Book1.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetShape()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorksheetShapeRequest("Book1.xlsx", "Sheet1")
        {
            ShapeDTO = new Shape(),
            DrawingType = "arc",
            UpperLeftRow = 1,
            UpperLeftColumn = 1,
            Top = 10,
            Left = 10,
            Width = 100,
            Height = 100,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetShapes()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetShapesRequest("Book1.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetShape()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetShapeRequest("Book1.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetShape()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetShapeRequest("Book1.xlsx", "Sheet1", 0, new Shape { LowerRightColumn = 10 })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetGroupShape()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetGroupShapeRequest("Book1.xlsx", "Sheet6", new List<int>())
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetUngroupShape()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetUngroupShapeRequest("Book1.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
