using System;
using System.IO;
using System.Linq;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Request;
using Xunit;

/// <summary>
/// Hand-written (non-generated) tests for <see cref="FileParameter"/>, verifying that FormData
/// parameters accept streams and raw bytes in addition to local paths. Lives in Manual/ so the
/// test-code generator (which wipes top-level *.cs) does not overwrite it.
/// </summary>
public class FileParameterTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;
    private const string RemoteFolder = "TestData/In";

    public FileParameterTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void UploadFileFromStream()
    {
        var bytes = File.ReadAllBytes("testdata/Book1.xlsx");
        using var stream = new MemoryStream(bytes);
        var remotePath = $"{RemoteFolder}/FileParameter_Stream_{Guid.NewGuid():N}.xlsx";

        var upload = _client.Do(new UploadFileRequest(
            FileParameter.FromStream(stream, "Book1.xlsx"),
            remotePath));
        Assert.Equal(200, upload.StatusCode);

        try
        {
            var download = _client.Do(new DownloadFileRequest(remotePath));
            Assert.Equal(200, download.StatusCode);
            Assert.True(bytes.SequenceEqual(download.ToBytes()), "uploaded stream content should round-trip");
        }
        finally
        {
            _client.Do(new DeleteFileRequest(remotePath));
        }
    }

    [Fact]
    public void UploadFileFromBytes()
    {
        var bytes = File.ReadAllBytes("testdata/Book1.xlsx");
        var remotePath = $"{RemoteFolder}/FileParameter_Bytes_{Guid.NewGuid():N}.xlsx";

        var upload = _client.Do(new UploadFileRequest(
            FileParameter.FromBytes(bytes, "Book1.xlsx"),
            remotePath));
        Assert.Equal(200, upload.StatusCode);

        try
        {
            var download = _client.Do(new DownloadFileRequest(remotePath));
            Assert.Equal(200, download.StatusCode);
            Assert.True(bytes.SequenceEqual(download.ToBytes()), "uploaded byte content should round-trip");
        }
        finally
        {
            _client.Do(new DeleteFileRequest(remotePath));
        }
    }

    [Fact]
    public void LocalPathStillWorks()
    {
        var remotePath = $"{RemoteFolder}/FileParameter_Path_{Guid.NewGuid():N}.xlsx";

        var upload = _client.Do(new UploadFileRequest("testdata/Book1.xlsx", remotePath));
        Assert.Equal(200, upload.StatusCode);

        try
        {
            var download = _client.Do(new DownloadFileRequest(remotePath));
            Assert.Equal(200, download.StatusCode);
        }
        finally
        {
            _client.Do(new DeleteFileRequest(remotePath));
        }
    }

    public void Dispose() { }
}
