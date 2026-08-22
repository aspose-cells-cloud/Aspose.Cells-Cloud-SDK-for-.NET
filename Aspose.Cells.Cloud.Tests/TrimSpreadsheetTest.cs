using System;
using System.Collections.Generic;
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Model;
using Aspose.Cells.Cloud.Request;
using Xunit;

public class TrimSpreadsheetTest : IDisposable
{
    private readonly AsposeCellsCloudClient _client;

    public TrimSpreadsheetTest()
    {
        _client = new AsposeCellsCloudClient(
            Environment.GetEnvironmentVariable("CellsCloudClientId") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudClientSecret") ?? string.Empty,
            Environment.GetEnvironmentVariable("CellsCloudApiBaseUrl"));
    }

    [Fact]
    public void TrimCharacter()
    {
        var request = new TrimCharacterRequest("TestData/BookText.xlsx")
        {
            TrimLeading = true,
            TrimTrailing = true,
            TrimSpaceBetweenWordTo1 = true,
            TrimNonBreakingSpaces = true,
            RemoveExtraLineBreaks = true,
            RemoveAllLineBreaks = true,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    [Fact]
    public void StartTrimCharacter()
    {
        var request = new TrimCharacterRequest("TestData/BookText.xlsx")
        {
            TrimLeading = true,
            TrimTrailing = false,
            TrimSpaceBetweenWordTo1 = false,
            TrimNonBreakingSpaces = true,
            RemoveExtraLineBreaks = true,
            RemoveAllLineBreaks = true,
        };
        RichResponse response = _client.Do(request);
        Assert.NotNull(response.Body);
    }

    // Skipped: unknown API method TrimWorksheetRange

    // Skipped: unknown API method TrimWorksheetRange

    public void Dispose() { }
}
