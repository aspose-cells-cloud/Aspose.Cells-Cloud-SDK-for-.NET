using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class WorkbookControllerTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public WorkbookControllerTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void PostDigitalSignature()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/roywang.pfx", "TestData/In/roywang.pfx"));
        var request = new PostDigitalSignatureRequest("Book1.xlsx", "TestData/In/roywang.pfx", "123456")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostEncryptWorkbook()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostEncryptWorkbookRequest("Book1.xlsx", new WorkbookEncryptionRequest { Password = "123456", EncryptionType = "XOR", KeyLength = 128 })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteDecryptWorkbook()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteDecryptWorkbookRequest("Book1.xlsx", new WorkbookEncryptionRequest { Password = "123456", EncryptionType = "XOR", KeyLength = 128 })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostProtectWorkbook()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostProtectWorkbookRequest("Book1.xlsx", new ProtectWorkbookRequest { EncryptWithPassword = "123456", ProtectWorkbookStructure = "ALL" })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteUnProtectWorkbook()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteUnProtectWorkbookRequest("Book1.xlsx", "Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorkbookDefaultStyle()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookDefaultStyleRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorkbookTextItems()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookTextItemsRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorkbookNames()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookNamesRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorkbookName()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorkbookNameRequest("Book1.xlsx", new Name { Text = "name_1804", Comment = "KeepSourceFormatting", RefersTo = "=Sheet1!$I$4" })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorkbookName()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookNameRequest("Book1.xlsx", "Name_2")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorkbookName()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookNameRequest("Book1.xlsx", "Name_2", new Name { Text = "name_1804", Comment = "KeepSourceFormatting", RefersTo = "=Sheet1!$I$4" })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorkbookNameValue()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookNameValueRequest("Book1.xlsx", "Name_2")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorkbookNames()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorkbookNamesRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorkbookName()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorkbookNameRequest("Book1.xlsx", "Name_2")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutDocumentProtectFromChanges()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutDocumentProtectFromChangesRequest("Book1.xlsx", new PasswordRequest { Password = "123456" })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteDocumentUnProtectFromChanges()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteDocumentUnProtectFromChangesRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorkbooksMerge()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/myDocument.xlsx", "TestData/In/myDocument.xlsx"));
        var request = new PostWorkbooksMergeRequest("Book1.xlsx", "TestData/In/myDocument.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorkbooksTextSearch()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbooksTextSearchRequest("Book1.xlsx", "1234")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorkbookTextReplace()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookTextReplaceRequest("Book1.xlsx", "1234", "5678")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorkbookGetSmartMarkerResult()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/ReportData.xml", "TestData/In/ReportData.xml"));
        var request = new PostWorkbookGetSmartMarkerResultRequest("Book1.xlsx")
        {
            XmlFile = "TestData/In/ReportData.xml",
            Folder = "TestData/In",
            OutPath = "OutResult/SmartMarkerResult.xlsx",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void PutWorkbookCreate()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/ReportData.xml", "TestData/In/ReportData.xml"));
        var request = new PutWorkbookCreateRequest("PutWorkbookCreate.xlsx")
        {
            TemplateFile = "TestData/In/Book1.xlsx",
            DataFile = "TestData/In/ReportData.xml",
            IsWriteOver = true,
            Folder = "TestData/In",
            CheckExcelRestriction = true,
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorkbookSplit()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSplitRequest("Book1.xlsx")
        {
            Format = "png",
            OutFolder = "OutResult",
            From = 1,
            To = 5,
            HorizontalResolution = 96,
            VerticalResolution = 96,
            SplitNameRule = "sheetname",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostImportData()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostImportDataRequest("Book1.xlsx")
        {
            ImportOption = new ImportIntArrayOption { DestinationWorksheet = "Sheet1", FirstColumn = 1, FirstRow = 3, ImportDataType = "IntArray", IsInsert = true, IsVertical = true, Data = new List<int>() },
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorkbookCalculateFormula()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookCalculateFormulaRequest("Book1.xlsx")
        {
            Options = new CalculationOptions { IgnoreError = true, Recursive = true },
            IgnoreError = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostAutofitWorkbookRows()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostAutofitWorkbookRowsRequest("Book1.xlsx")
        {
            StartRow = 1,
            EndRow = 100,
            OnlyAuto = true,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostAutofitWorkbookColumns()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostAutofitWorkbookColumnsRequest("Book1.xlsx")
        {
            StartColumn = 1,
            EndColumn = 20,
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetWorkbookSettings()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetWorkbookSettingsRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PostWorkbookSettings()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PostWorkbookSettingsRequest("Book1.xlsx", new WorkbookSettings { AutoCompressPictures = true, HidePivotFieldList = true })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorkbookBackground()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        _client.Do(new UploadFileRequest("testdata/WaterMark.png", "TestData/In/WaterMark.png"));
        var request = new PutWorkbookBackgroundRequest("Book1.xlsx")
        {
            PicPath = "TestData/In/WaterMark.png",
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void DeleteWorkbookBackground()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new DeleteWorkbookBackgroundRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void PutWorkbookWaterMarker()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new PutWorkbookWaterMarkerRequest("Book1.xlsx", new TextWaterMarkerRequest { Text = "Aspose Cells Cloud", FontSize = 12 })
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.Equal(200, response.StatusCode);
    }

    [Fact]
    public void GetPageCount()
    {
        _client.Do(new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx"));
        var request = new GetPageCountRequest("Book1.xlsx")
        {
            Folder = "TestData/In",
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    public void Dispose() { }
}
