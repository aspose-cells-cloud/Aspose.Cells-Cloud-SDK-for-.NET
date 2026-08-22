using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class ConversionTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public ConversionTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void WorkbookSaveAs_1()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new SaveSpreadsheetAsRequest("Book1.xlsx", "csv")
        {
            SaveOptionsData = new SaveOptionsData { Filename = "OutResult/PostExcelSaveAs.csv" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_2()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new SaveSpreadsheetAsRequest("Book1.xlsx", "pdf")
        {
            SaveOptionsData = new SaveOptionsData { Filename = "OutResult/PostExcelSaveAs.pdf" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void ConvertWorkbook_1()
    {
        var request = new ConvertSpreadsheetRequest("TestData/Book1.xlsx", "png");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_2()
    {
        var request = new ConvertSpreadsheetRequest("TestData/Book1.xlsx", "sql");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertSpreadsheetToPdf()
    {
        var request = new ConvertSpreadsheetToPdfRequest("TestData/Book1.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertSpreadsheetToCsv()
    {
        var request = new ConvertSpreadsheetToCsvRequest("TestData/Book1.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertSpreadsheetToJSON()
    {
        var request = new ConvertSpreadsheetToJsonRequest("TestData/Book1.xlsx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud()
    {
        var request = new ConvertSpreadsheetRequest("TestData/Book1.xlsx", "csv")
        {
            OutPath = "OutResult/ConvertWorkbook.csv",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorksheetToSvg()
    {
        var request = new ConvertWorksheetToImageRequest("TestData/TestTables.xlsx", "Sheet2", "svg");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorksheetToPng()
    {
        var request = new ConvertWorksheetToImageRequest("TestData/TestTables.xlsx", "Sheet2", "png");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorksheetToTiff()
    {
        var request = new ConvertWorksheetToImageRequest("TestData/TestTables.xlsx", "Sheet2", "tiff");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorksheetToPdf()
    {
        var request = new ConvertWorksheetToPdfRequest("TestData/TestTables.xlsx", "Sheet2");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorksheetToCsv()
    {
        var request = new ConvertWorksheetToCsvRequest("TestData/TestTables.xlsx", "Sheet2");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorksheetToHtml()
    {
        var request = new ConvertWorksheetToHtmlRequest("TestData/TestTables.xlsx", "Sheet2");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    // Skipped: unknown API method ConvertWorksheetToTable

    [Fact]
    public void ConvertWorksheetToHtmlTable()
    {
        var request = new ConvertWorksheetToHtmlTableRequest("TestData/TestTables.xlsx", "Sheet2");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertTableToSvg()
    {
        var request = new ConvertTableToImageRequest("TestData/TestTables.xlsx", "Sheet2", "Table13", "svg");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertTableToPng()
    {
        var request = new ConvertTableToImageRequest("TestData/TestTables.xlsx", "Sheet2", "Table13", "png");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertTableToPdf()
    {
        var request = new ConvertTableToPdfRequest("TestData/TestTables.xlsx", "Sheet2", "Table13");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertTableToCsv()
    {
        var request = new ConvertTableToCsvRequest("TestData/TestTables.xlsx", "Sheet2", "Table13");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertTableToHtml()
    {
        var request = new ConvertTableToHtmlRequest("TestData/TestTables.xlsx", "Sheet2", "Table13");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertTableToJson()
    {
        var request = new ConvertTableToJsonRequest("TestData/TestTables.xlsx", "Sheet2", "Table13");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertRangeToImage()
    {
        var request = new ConvertRangeToImageRequest("TestData/TestTables.xlsx", "Sheet2", "B2:F10", "svg");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertRangeToPdf()
    {
        var request = new ConvertRangeToPdfRequest("TestData/TestTables.xlsx", "Sheet2", "A1:F10");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertRangeToCsv()
    {
        var request = new ConvertRangeToCsvRequest("TestData/TestTables.xlsx", "Sheet2", "A1:F10");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertRangeToHtml()
    {
        var request = new ConvertRangeToHtmlRequest("TestData/TestTables.xlsx", "Sheet2", "A1:F10");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertRangeToJson()
    {
        var request = new ConvertRangeToJsonRequest("TestData/TestTables.xlsx", "Sheet2", "A1:F10");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertChartToImage()
    {
        var request = new ConvertChartToImageRequest("TestData/EmployeeSalesSummary.xlsx", "Sales", 0, "svg");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertChartToPdf()
    {
        var request = new ConvertChartToPdfRequest("TestData/EmployeeSalesSummary.xlsx", "Sales", 0);
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExportSpreadsheetAsFormat_1()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new ExportSpreadsheetAsFormatRequest("Book1.xlsx", "pdf")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExportSpreadsheetAsFormat_2()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new ExportSpreadsheetAsFormatRequest("Book1.xlsx", "pptx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExportSpreadsheetAsFormat_3()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new ExportSpreadsheetAsFormatRequest("Book1.xlsx", "json")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExportWorksheetAsFormat()
    {
        _client.Do(new UploadFileRequest("testdata/EmployeeSalesSummary.xlsx", "TestData/In/EmployeeSalesSummary.xlsx"));
        var request = new ExportWorksheetAsFormatRequest("EmployeeSalesSummary.xlsx", "Sales", "svg")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExportChartAsFormat()
    {
        _client.Do(new UploadFileRequest("testdata/EmployeeSalesSummary.xlsx", "TestData/In/EmployeeSalesSummary.xlsx"));
        var request = new ExportChartAsFormatRequest("EmployeeSalesSummary.xlsx", "Sales", 0, "svg")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExportTableAsFormat()
    {
        _client.Do(new UploadFileRequest("testdata/TestTables.xlsx", "TestData/In/TestTables.xlsx"));
        var request = new ExportTableAsFormatRequest("TestTables.xlsx", "Sheet2", "Table13", "svg")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ExportRangeAsFormat()
    {
        _client.Do(new UploadFileRequest("testdata/EmployeeSalesSummary.xlsx", "TestData/In/EmployeeSalesSummary.xlsx"));
        var request = new ExportRangeAsFormatRequest("EmployeeSalesSummary.xlsx", "Sales", "A1:F16", "svg")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
