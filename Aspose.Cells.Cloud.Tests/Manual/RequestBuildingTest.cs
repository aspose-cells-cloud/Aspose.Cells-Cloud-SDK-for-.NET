using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Request;
using Xunit;

/// <summary>
/// Hand-written offline tests that exercise the request classes' contract (GetPath / GetQueryParameters /
/// GetMultipartForm) without any network access or credentials. Lives in Manual/ so the test-code
/// generator (which wipes top-level *.cs) does not overwrite it.
/// </summary>
public class RequestBuildingTest
{
    [Fact]
    public void PostClearContents_BuildsPathAndQuery()
    {
        var request = new PostClearContentsRequest("Book1.xlsx", "Sheet1")
        {
            Range = "A1:C10",
            StartRow = 2,
            Folder = "TestData/In",
            StorageName = "storage",
        };

        Assert.Equal("POST", request.GetMethod());
        Assert.Equal("/v3.0/cells/Book1.xlsx/worksheets/Sheet1/cells/clearcontents", request.GetPath());

        var query = request.GetQueryParameters();
        Assert.Equal("A1:C10", query["range"]);
        Assert.Equal("2", query["startRow"]);
        Assert.Equal("TestData/In", query["folder"]);
        Assert.Equal("storage", query["storageName"]);
        Assert.False(query.ContainsKey("endRow"), "absent optional query params must be omitted");
    }

    [Fact]
    public void UploadFile_FormsMultipartKeyedByFileName()
    {
        var request = new UploadFileRequest(FileParameter.FromPath("testdata/Book1.xlsx"), "TestData/In/Book1.xlsx");

        Assert.Equal("PUT", request.GetMethod());
        Assert.Contains("/storage/file/", request.GetPath());

        var form = request.GetMultipartForm();
        Assert.NotNull(form);
        var file = Assert.IsType<FileParameter>(Assert.Single(form).Value);
        Assert.Equal("Book1.xlsx", file.FileName);
    }

    [Fact]
    public void EscapeDataString_EncodesSlashAndSpaceInFilePath()
    {
        var request = new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Sub Folder/Book1.xlsx");

        Assert.Contains("Sub%20Folder", request.GetPath());
    }

    [Fact]
    public void OptionalFile_ReturnsNullFormWhenUnset()
    {
        var request = new PutWorkbookBackgroundRequest("Book1.xlsx");

        Assert.Null(request.GetMultipartForm());
    }

    [Fact]
    public void OptionalFile_ReturnsFormWhenSet()
    {
        var request = new PutWorkbookBackgroundRequest("Book1.xlsx")
        {
            File = FileParameter.FromBytes(new byte[] { 1, 2, 3 }, "bg.png"),
        };

        var form = request.GetMultipartForm();
        Assert.NotNull(form);
        var file = Assert.IsType<FileParameter>(Assert.Single(form).Value);
        Assert.Equal("bg.png", file.FileName);
    }
}
