using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class PivotTablesControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public PivotTablesControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetWorksheetPivotTables()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new GetWorksheetPivotTablesRequest("TestCase.xlsx", "Sheet4")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetPivotTable()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new GetWorksheetPivotTableRequest("TestCase.xlsx", "Sheet4", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetPivotTableField()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new GetPivotTableFieldRequest("TestCase.xlsx", "Sheet4", 0, 0, "Row")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetPivotTableFilters()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new GetWorksheetPivotTableFiltersRequest("TestCase.xlsx", "Sheet4", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetPivotTable()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PutWorksheetPivotTableRequest("TestCase.xlsx", "Sheet4")
        {
            Folder = "TestData/In",
            SourceData = "=Sheet1!C6:E13",
            DestCellName = "C1",
            TableName = "TestPivot",
            UseSameSource = true,
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutPivotTableField()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PutPivotTableFieldRequest("TestCase.xlsx", "Sheet4", 0, "Row", new PivotTableFieldRequest { Data = new List<int>() })
        {
            NeedReCalculate = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostPivotTableFieldHideItem()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostPivotTableFieldHideItemRequest("TestCase.xlsx", "Sheet4", 0, "Row", 0, 1, true)
        {
            NeedReCalculate = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostPivotTableFieldMoveTo()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostPivotTableFieldMoveToRequest("TestCase.xlsx", "Sheet4", 0, 0, "Row", "Column")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostPivotTableCellStyle()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostPivotTableCellStyleRequest("TestCase.xlsx", "Sheet4", 0, 1, 1, new Style { Font = new Font { Size = 16 } })
        {
            NeedReCalculate = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostPivotTableStyle()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostPivotTableStyleRequest("TestCase.xlsx", "Sheet4", 0, new Style { Font = new Font { Size = 16 } })
        {
            NeedReCalculate = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostPivotTableUpdatePivotFields()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostPivotTableUpdatePivotFieldsRequest("TestCase.xlsx", "Sheet4", 0, "Row", new PivotField { ShowCompact = true })
        {
            NeedReCalculate = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostPivotTableUpdatePivotField()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostPivotTableUpdatePivotFieldRequest("TestCase.xlsx", "Sheet4", 0, 0, "Row", new PivotField { ShowCompact = true })
        {
            NeedReCalculate = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetPivotTableCalculate()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostWorksheetPivotTableCalculateRequest("TestCase.xlsx", "Sheet4", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorksheetPivotTableMove()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new PostWorksheetPivotTableMoveRequest("TestCase.xlsx", "Sheet4", 0)
        {
            Row = 1,
            Column = 1,
            DestCellName = "C10",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetPivotTables()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new DeleteWorksheetPivotTablesRequest("TestCase.xlsx", "Sheet4")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetPivotTable()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new DeleteWorksheetPivotTableRequest("TestCase.xlsx", "Sheet4", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeletePivotTableField()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new DeletePivotTableFieldRequest("TestCase.xlsx", "Sheet4", 0, "Row", new PivotTableFieldRequest { Data = new List<int>() })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetPivotTableFilters()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new DeleteWorksheetPivotTableFiltersRequest("TestCase.xlsx", "Sheet3", 0)
        {
            NeedReCalculate = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetPivotTableFilter()
    {
        _client.Do(new UploadFileRequest("testdata/TestCase.xlsx", "TestData/In/TestCase.xlsx"));
        var request = new DeleteWorksheetPivotTableFilterRequest("TestCase.xlsx", "Sheet3", 0, 0)
        {
            NeedReCalculate = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
