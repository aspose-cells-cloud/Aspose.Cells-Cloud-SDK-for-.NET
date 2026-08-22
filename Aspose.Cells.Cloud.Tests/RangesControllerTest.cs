using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class RangesControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public RangesControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void PostWorksheetCellsRangesCopy()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangesCopyRequest("Book1.xlsx", "Sheet1", new RangeCopyRequest { Operate = "copydata", Source = new Aspose.Cells.Cloud.Model.Range { ColumnCount = 3, FirstColumn = 8, FirstRow = 3, RowCount = 2 }, Target = new Aspose.Cells.Cloud.Model.Range { ColumnCount = 3, FirstColumn = 8, FirstRow = 13, RowCount = 2 } })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeMerge()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangeMergeRequest("Book1.xlsx", "Sheet1", new Aspose.Cells.Cloud.Model.Range { ColumnCount = 1, ColumnWidth = 10.0, FirstRow = 1, RowCount = 10 })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeUnMerge()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangeUnMergeRequest("Book1.xlsx", "Sheet1", new Aspose.Cells.Cloud.Model.Range { ColumnCount = 1, ColumnWidth = 10.0, FirstRow = 1, RowCount = 10 })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeStyle()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangeStyleRequest("Book1.xlsx", "Sheet1", new RangeSetStyleRequest { Style = new Style { Font = new Font { Size = 16 } }, Range = new Aspose.Cells.Cloud.Model.Range { ColumnCount = 1, ColumnWidth = 10.0, FirstRow = 1, RowCount = 10 } })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetCellsRangeValue()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetCellsRangeValueRequest("Book1.xlsx", "Sheet1")
        {
            Namerange = "Name_2",
            FirstRow = 0,
            FirstColumn = 0,
            RowCount = 3,
            ColumnCount = 2,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeValue()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangeValueRequest("Book1.xlsx", "Sheet1", new Aspose.Cells.Cloud.Model.Range { ColumnCount = 1, ColumnWidth = 10.0, FirstRow = 1, RowCount = 10 }, "100")
        {
            IsConverted = true,
            SetStyle = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeMoveTo()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangeMoveToRequest("Book1.xlsx", "Sheet1", new Aspose.Cells.Cloud.Model.Range { ColumnCount = 1, ColumnWidth = 10.0, FirstRow = 1, RowCount = 10 }, 10, 10)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeOutlineBorder()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangeOutlineBorderRequest("Book1.xlsx", "Sheet1", new RangeSetOutlineBorderRequest { BorderEdge = "LeftBorder", BorderStyle = "Dotted", BorderColor = new Color { R = 48, G = 48, B = 48 }, Range = new Aspose.Cells.Cloud.Model.Range { ColumnCount = 1, ColumnWidth = 10.0, FirstRow = 1, RowCount = 10 } })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeColumnWidth()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangeColumnWidthRequest("Book1.xlsx", "Sheet1", new Aspose.Cells.Cloud.Model.Range { ColumnCount = 1, ColumnWidth = 10.0, FirstRow = 1, RowCount = 10 }, 10.7)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeRowHeight()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorksheetCellsRangeRowHeightRequest("Book1.xlsx", "Sheet1", new Aspose.Cells.Cloud.Model.Range { ColumnCount = 1, ColumnWidth = 10.0, FirstRow = 1, RowCount = 10 }, 10.9)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetCellsRange()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorksheetCellsRangeRequest("Book1.xlsx", "Sheet1", "A1:C6", "Down")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetCellsRange()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetCellsRangeRequest("Book1.xlsx", "Sheet1", "A1:C6", "Up")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetCellsRangeSort()
    {
        _client.Do(new UploadFileRequest("testdata/Group.xlsx", "TestData/In/Group.xlsx"));
        var request = new PostWorksheetCellsRangeSortRequest("Group.xlsx", "book1", new RangeSortRequest { DataSorter = new DataSorter { CaseSensitive = true }, CellArea = new Aspose.Cells.Cloud.Model.Range { ColumnCount = 3, FirstColumn = 0, FirstRow = 0, RowCount = 15 } })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
