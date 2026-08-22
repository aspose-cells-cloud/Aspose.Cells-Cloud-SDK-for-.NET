using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ConditionalFormattingsControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ConditionalFormattingsControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void GetWorksheetConditionalFormattings()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetConditionalFormattingsRequest("Book1.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorksheetConditionalFormatting()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorksheetConditionalFormattingRequest("Book1.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetConditionalFormatting()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorksheetConditionalFormattingRequest("Book1.xlsx", "Sheet1", new FormatCondition { Type = "CellValue", Operator = "Between", Formula1 = "v1", Formula2 = "v2" }, "A1:C10")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetFormatCondition()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorksheetFormatConditionRequest("Book1.xlsx", "Sheet1", 0, "A1:C10", "CellValue", "Between", "v1", "v2")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetFormatConditionArea()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorksheetFormatConditionAreaRequest("Book1.xlsx", "Sheet1", 0, "A1:C10")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorksheetFormatConditionCondition()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorksheetFormatConditionConditionRequest("Book1.xlsx", "Sheet1", 0, "CellValue", "Between", "v1", "v2")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetConditionalFormattings()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetConditionalFormattingsRequest("Book1.xlsx", "Sheet1")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetConditionalFormatting()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetConditionalFormattingRequest("Book1.xlsx", "Sheet1", 0)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorksheetConditionalFormattingArea()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorksheetConditionalFormattingAreaRequest("Book1.xlsx", "Sheet1", 1, 1, 4, 6)
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    public void Dispose() { }
}
