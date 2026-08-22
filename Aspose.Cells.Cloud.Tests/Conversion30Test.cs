using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class Conversion30Test : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public Conversion30Test()
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
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.csv")
        {
            SaveOptions = new SaveOptions { SaveFormat = "csv" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_2()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.html")
        {
            SaveOptions = new SaveOptions { SaveFormat = "html" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_3()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.mhtml")
        {
            SaveOptions = new SaveOptions { SaveFormat = "mhtml" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_4()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.ods")
        {
            SaveOptions = new SaveOptions { SaveFormat = "ods" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_5()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.pdf")
        {
            SaveOptions = new SaveOptions { SaveFormat = "pdf" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_6()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.xml")
        {
            SaveOptions = new SaveOptions { SaveFormat = "xml" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_7()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.txt")
        {
            SaveOptions = new SaveOptions { SaveFormat = "txt" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_8()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.tif")
        {
            SaveOptions = new SaveOptions { SaveFormat = "tif" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_9()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.xlsb")
        {
            SaveOptions = new SaveOptions { SaveFormat = "xlsb" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_10()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.xps")
        {
            SaveOptions = new SaveOptions { SaveFormat = "xps" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_11()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.png")
        {
            SaveOptions = new SaveOptions { SaveFormat = "png" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_12()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.md")
        {
            SaveOptions = new SaveOptions { SaveFormat = "md" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_13()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.svg")
        {
            SaveOptions = new SaveOptions { SaveFormat = "svg" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_14()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.docx")
        {
            SaveOptions = new SaveOptions { SaveFormat = "docx" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_15()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.pptx")
        {
            SaveOptions = new SaveOptions { SaveFormat = "pptx" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_16()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.json")
        {
            SaveOptions = new SaveOptions { SaveFormat = "json" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void WorkbookSaveAs_17()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSaveAsRequest("Book1.xlsx", "OutResult/PostExcelSaveAs.sql")
        {
            SaveOptions = new SaveOptions { SaveFormat = "sql" },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorkbookFormat_1()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "csv",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_2()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "html",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_3()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "mhtml",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_4()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "ods",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_5()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "pdf",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_6()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "xml",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_7()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "txt",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_8()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "tif",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_9()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "xps",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_10()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "png",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_11()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "md",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_12()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "svg",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_13()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "docx",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_14()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "pptx",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_15()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "json",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void GetWorkbookFormat_16()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookRequest("Book1.xlsx")
        {
            Format = "sql",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_1()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "csv");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_2()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xls");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_3()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "html");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_4()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "mhtml");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_5()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "ods");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_6()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "pdf");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_7()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xml");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_8()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "txt");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_9()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "tif");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_10()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xlsb");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_11()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xps");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_12()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "png");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_13()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "md");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_14()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "svg");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_15()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "docx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_16()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "pptx");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_17()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "json");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbook_18()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "sql");
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_1()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "csv")
        {
            OutPath = "OutResult/ConvertWorkbook.csv",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_2()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xls")
        {
            OutPath = "OutResult/ConvertWorkbook.xls",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_3()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "html")
        {
            OutPath = "OutResult/ConvertWorkbook.html",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_4()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "mhtml")
        {
            OutPath = "OutResult/ConvertWorkbook.mhtml",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_5()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "ods")
        {
            OutPath = "OutResult/ConvertWorkbook.ods",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_6()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "pdf")
        {
            OutPath = "OutResult/ConvertWorkbook.pdf",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_7()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xml")
        {
            OutPath = "OutResult/ConvertWorkbook.xml",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_8()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "txt")
        {
            OutPath = "OutResult/ConvertWorkbook.txt",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_9()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "tif")
        {
            OutPath = "OutResult/ConvertWorkbook.tif",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_10()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xlsb")
        {
            OutPath = "OutResult/ConvertWorkbook.xlsb",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_11()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xltm")
        {
            OutPath = "OutResult/ConvertWorkbook.xltm",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_12()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "xps")
        {
            OutPath = "OutResult/ConvertWorkbook.xps",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_13()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "png")
        {
            OutPath = "OutResult/ConvertWorkbook.png",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_14()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "md")
        {
            OutPath = "OutResult/ConvertWorkbook.md",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_15()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "svg")
        {
            OutPath = "OutResult/ConvertWorkbook.svg",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_16()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "docx")
        {
            OutPath = "OutResult/ConvertWorkbook.docx",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_17()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "pptx")
        {
            OutPath = "OutResult/ConvertWorkbook.pptx",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_18()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "json")
        {
            OutPath = "OutResult/ConvertWorkbook.json",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void ConvertWorkbookSaveCloud_19()
    {
        var request = new PutConvertWorkbookRequest("testdata/Book1.xlsx", "sql")
        {
            OutPath = "OutResult/ConvertWorkbook.sql",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
