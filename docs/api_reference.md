# API Reference

## Overview

The Aspose.Cells Cloud SDK for .NET exposes **461 API operations across 42 controllers** through a
single `Aspose.Cells.Cloud.AsposeCellsCloudClient`.

## Client

### Initialization

```csharp
using Aspose.Cells.Cloud;

var client = new AsposeCellsCloudClient(
    "your-client-id",             // Aspose Cloud Client ID
    "your-client-secret",         // Aspose Cloud Client Secret
    "https://api.aspose.cloud"    // base URL (optional; defaults to production)
);

client.Configuration.Timeout = TimeSpan.FromSeconds(30);   // default 30s
client.Configuration.Retries = 3;                           // default 0
client.Configuration.AddDefaultHeader("X-Custom", "value");
```

### Executing Requests

```csharp
using Aspose.Cells.Cloud;
using Aspose.Cells.Cloud.Request;

var request = new PostCellCharactersRequest("Book1.xlsx", "Sheet1", "D4")
{
    Folder = "TestData/In",        // optional
    Options = new List<FontSetting> { fontSetting },   // optional
};

try
{
    RichResponse response = client.Do(request);   // throws SDKException on failure
    Console.WriteLine(response.StatusCode);
    Console.WriteLine(response);                   // ToString() => body
}
catch (SDKException e)
{
    Console.Error.WriteLine($"SDK error: {e.Message}");
}

// async
RichResponse response2 = await client.DoAsync(request);
```

`Do(IRequestOption)` executes a single request and returns a `RichResponse`. To run several requests at
once, use `DoBatch(params IRequestOption[] requests)`, which returns a `List<RichResponse>`.

### Response

```csharp
public class RichResponse
{
    public int StatusCode { get; set; }                          // HTTP status code
    public Dictionary<string, List<string>> Headers { get; set; } // response headers
    public byte[] Body { get; set; }                             // raw body bytes

    public override string ToString();    // body decoded as UTF-8
    public byte[] ToBytes();              // body as bytes
    public T GetJson<T>();                // deserialize JSON into a model
}
```

## Controllers

Operations are grouped by controller. Each operation maps to a request class under
`Aspose.Cells.Cloud.Request/`.

### CellsController (40 operations)

Cell-level operations on worksheets.

| Operation | Method | Path |
|-----------|--------|------|
| `PostClearContents` | POST | `/cells/{name}/worksheets/{sheetName}/cells/clearcontents` |
| `PostClearFormats` | POST | `/cells/{name}/worksheets/{sheetName}/cells/clearformats` |
| `PostCopyCellIntoCell` | POST | `/cells/{name}/worksheets/{sheetName}/cells/{cellName}/copy` |
| `PostSetCellHtmlString` | POST | `/cells/{name}/worksheets/{sheetName}/cells/{cellName}/htmlstring` |
| `PostSetCellRangeValue` | POST | `/cells/{name}/worksheets/{sheetName}/cells` |
| `PostUpdateWorksheetRangeStyle` | POST | `/cells/{name}/worksheets/{sheetName}/cells/style` |
| `PostWorksheetMerge` | POST | `/cells/{name}/worksheets/{sheetName}/cells/merge` |
| `PostWorksheetUnmerge` | POST | `/cells/{name}/worksheets/{sheetName}/cells/unmerge` |
| `PostCellCharacters` | POST | `/cells/{name}/worksheets/{sheetName}/cells/{cellName}/characters` |
| `GetWorksheetColumns` | GET | `/cells/{name}/worksheets/{sheetName}/columns` |
| `GetWorksheetRows` | GET | `/cells/{name}/worksheets/{sheetName}/cells/rows` |
| `GetWorksheetCell` | GET | `/cells/{name}/worksheets/{sheetName}/cells/{cellName}` |
| `GetWorksheetCellStyle` | GET | `/cells/{name}/worksheets/{sheetName}/cells/{cellName}/style` |

### WorkbookController (25 operations)

| Operation | Method | Path |
|-----------|--------|------|
| `PostWorkbookSaveAs` | POST | `/cells/{name}/saveAs` |
| `PostWorkbookMerge` | POST | `/cells/{name}/merge` |
| `PostWorkbookSplit` | POST | `/cells/{name}/split` |
| `PostWorkbookProtect` | POST | `/cells/{name}/protection` |
| `PostWorkbookEncrypt` | POST | `/cells/{name}/encryption` |
| `PostWorkbookDecrypt` | POST | `/cells/{name}/decryption` |
| `PostWorkbookSettings` | POST | `/cells/{name}/settings` |
| `GetWorkbook` | GET | `/cells/{name}` |
| `GetWorkbookSettings` | GET | `/cells/{name}/settings` |
| `CreateWorkbook` | PUT | `/cells/{name}` |

### WorksheetsController (39 operations)

| Operation | Method | Path |
|-----------|--------|------|
| `PutAddNewWorksheet` | PUT | `/cells/{name}/worksheets/{sheetName}` |
| `DeleteWorksheet` | DELETE | `/cells/{name}/worksheets/{sheetName}` |
| `PostCopyWorksheet` | POST | `/cells/{name}/worksheets/{sheetName}/copy` |
| `PostRenameWorksheet` | POST | `/cells/{name}/worksheets/{sheetName}/rename` |
| `PostMoveWorksheet` | POST | `/cells/{name}/worksheets/{sheetName}/move` |
| `PostHideWorksheet` | POST | `/cells/{name}/worksheets/{sheetName}/hide` |
| `PostUnhideWorksheet` | POST | `/cells/{name}/worksheets/{sheetName}/unhide` |
| `GetWorksheet` | GET | `/cells/{name}/worksheets/{sheetName}` |
| `GetWorksheets` | GET | `/cells/{name}/worksheets` |

### ConversionController (42 operations)

| Operation | Method | Path |
|-----------|--------|------|
| `PostWorkbookSaveAs` | POST | `/cells/{name}/saveAs` |
| `PutConvertWorkbook` | PUT | `/cells/convert` |
| `GetWorksheetWithFormat` | GET | `/cells/{name}/worksheets/{sheetName}` |
| `PostWorkbookExportAs` | POST | `/cells/{name}/export` |
| `PostWorkbookToPdf` | POST | `/cells/{name}/toPdf` |
| `PostWorkbookToHtml` | POST | `/cells/{name}/toHtml` |

### ChartsController (24 operations)

| Operation | Method | Path |
|-----------|--------|------|
| `PutWorksheetAddChart` | PUT | `/cells/{name}/worksheets/{sheetName}/charts` |
| `DeleteWorksheetChart` | DELETE | `/cells/{name}/worksheets/{sheetName}/charts/{chartIndex}` |
| `GetWorksheetChart` | GET | `/cells/{name}/worksheets/{sheetName}/charts/{chartIndex}` |
| `GetWorksheetCharts` | GET | `/cells/{name}/worksheets/{sheetName}/charts` |
| `PostWorksheetChart` | POST | `/cells/{name}/worksheets/{sheetName}/charts/{chartIndex}` |

### DataProcessingController (23 operations)

| Operation | Method | Path |
|-----------|--------|------|
| `PostWorkbookMerge` | POST | `/cells/{name}/merge` |
| `PostWorkbookSplit` | POST | `/cells/{name}/split` |
| `PostImportData` | POST | `/cells/{name}/importdata` |
| `PostWorkbookProtect` | POST | `/cells/{name}/protection` |

### File & Storage Controllers

| Operation | Method | Path |
|-----------|--------|------|
| `UploadFile` | PUT | `/cells/storage/file/{path}` |
| `DownloadFile` | GET | `/cells/storage/file/{path}` |
| `CopyFile` | PUT | `/cells/storage/file/copy/{path}` |
| `MoveFile` | PUT | `/cells/storage/file/move/{path}` |
| `DeleteFile` | DELETE | `/cells/storage/file/{path}` |
| `CreateFolder` | PUT | `/cells/storage/folder/{path}` |
| `DeleteFolder` | DELETE | `/cells/storage/folder/{path}` |
| `GetFilesList` | GET | `/cells/storage/folder/{path}` |
| `GetDiscUsage` | GET | `/cells/storage/disc` |

### Other Notable Controllers

| Controller | Operations | Key Features |
|-----------|-----------|-------------|
| `TextProcessingController` | 24 | Add/extract/convert/trim text, word case |
| `PivotTablesController` | 21 | Pivot table CRUD and filtering |
| `LightCellsController` | 15 | Lightweight batch operations |
| `SearchController` | 14 | Text search and replace |
| `RangesController` | 14 | Named range operations |
| `AutoFilterController` | 13 | AutoFilter and date/custom filters |
| `ListObjectsController` | 13 | List objects (tables) management |
| `ConditionalFormattingsController` | 9 | Format conditions, data bars |
| `ShapesController` | 8 | Shape management |
| `PicturesController` | 7 | Picture insert/update/delete |
| `SparklineGroupsController` | 6 | Sparkline management |
| `AIController` | 5 | AI translation, summarization |
| `BatchController` | 5 | Batch convert/protect/lock/split |

## Common Parameters

Available across most operations (as optional object-initializer properties):

| Property | C# type | Description |
|----------|---------|-------------|
| `Folder` | `string` | Remote folder path |
| `StorageName` | `string` | Storage name (default: empty) |
| `Password` | `string` | File password for encrypted files |
| `Region` | `string` | Locale setting (e.g. `en-US`) |

## Error Handling

All request/HTTP failures throw an `SDKException` (extends `Exception`):

```csharp
try
{
    RichResponse response = client.Do(request);
}
catch (SDKException e)
{
    Console.Error.WriteLine($"SDK Error [{(e.Code.HasValue ? e.Code.Value : 0)}]: {e.Message}");
}
```
