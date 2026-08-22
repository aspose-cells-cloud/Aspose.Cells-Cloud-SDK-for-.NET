using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ListObjectsControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ListObjectsControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetWorksheetListObjects()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetListObjectsRequest("Book1.xlsx", "Sheet7")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetListObject()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetListObjectRequest("Book1.xlsx", "Sheet7", 0)
        {
            Format = "pdf",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PutWorksheetListObject()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorksheetListObjectRequest("Book1.xlsx", "Sheet7")
        {
            StartRow = 1,
            StartColumn = 1,
            EndRow = 6,
            EndColumn = 6,
            Folder = "TestData/In",
            HasHeaders = true,
            DisplayName = "true",
            ShowTotals = false,
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetListObjects()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetListObjectsRequest("Book1.xlsx", "Sheet7")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetListObject()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetListObjectRequest("Book1.xlsx", "Sheet7", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetListObject()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetListObjectRequest("Book1.xlsx", "Sheet7", 0, new ListObject { ShowHeaderRow = true })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetListObjectConvertToRange()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetListObjectConvertToRangeRequest("Book1.xlsx", "Sheet7", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetListObjectSummarizeWithPivotTable()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetListObjectSummarizeWithPivotTableRequest("Book1.xlsx", "Sheet7", 0, "Sheet2", new CreatePivotTableRequest { DestCellName = "C1", Name = "testp", SourceData = "=Sheet2!A1:E8", UseSameSource = true, PivotFieldColumns = new List<int>(), PivotFieldData = new List<int>(), PivotFieldRows = new List<int>() })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetListObjectSortTable()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetListObjectSortTableRequest("Book1.xlsx", "Sheet7", 0, new DataSorter { CaseSensitive = true })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetListColumn()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetListColumnRequest("Book1.xlsx", "Sheet7", 0, 0, new ListColumn { Name = "test cloumn" })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetListColumnsTotal()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetListColumnsTotalRequest("Book1.xlsx", "Sheet7", 0, new List<TableTotalRequest>())
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetListObjectRemoveDuplicates()
    {
        _client.Do(new UploadFileRequest("testdata/TestTables.xlsx", "TestData/In/TestTables.xlsx"));
        var request = new PostWorksheetListObjectRemoveDuplicatesRequest("TestTables.xlsx", "Sheet2", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetListObjectInsertSlicer()
    {
        _client.Do(new UploadFileRequest("testdata/TestTables.xlsx", "TestData/In/TestTables.xlsx"));
        var request = new PostWorksheetListObjectInsertSlicerRequest("TestTables.xlsx", "Sheet1", 0, 2, "j9")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
