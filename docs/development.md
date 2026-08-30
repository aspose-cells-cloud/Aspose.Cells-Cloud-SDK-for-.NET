# Development Guide

## Project Overview

This SDK is generated from `aspose.cells.cloud.specification.json` (461 operations, 4 marked `Ignored`, 42
controllers, 483 data models) and mirrors the structure of the Aspose.Cells Cloud SDK for Go, translated to
idiomatic C#. The 483 spec models comprise **451 class models** (emitted) and **32 empty enums** (skipped);
the 461 operations yield **457 request classes** (the 4 `Ignored` operations are skipped).

## Directory Structure

```
cells-cloud-sdk-net/
├── Aspose.Cells.Cloud.sln                 # solution
├── Aspose.Cells.Cloud/
│   ├── Aspose.Cells.Cloud.csproj          # SDK library project (NuGet package metadata)
│   ├── AsposeCellsCloudClient.cs          # client + OAuth2 + HTTP execution + retries/timeout
│   ├── Configuration.cs                   # credentials, base URL, timeout, retries, default headers
│   ├── IRequestOption.cs                  # request interface
│   ├── FileParameter.cs                   # multipart file source (path / stream / bytes)
│   ├── RichResponse.cs                    # response wrapper
│   ├── SDKException.cs                    # SDK/HTTP error type
│   ├── Version.cs                         # SDK version constant
│   ├── Model/                             # 451 model classes (one per file)
│   └── Request/                           # 457 request classes (one per operation)
├── Aspose.Cells.Cloud.Tests/              # xUnit test project (49 classes / 495 cases; Manual/ = hand-written)
├── TestingData/                           # JSON test-case configuration
├── testdata/                              # sample XLSX / CSV / ODS files
├── generate_models.py                     # model generation script
├── generate_requests.py                   # request generation script
├── generate_tests.py                      # test generation script
├── docs/                                  # user / developer / testing guides
└── references/                            # generation rules (see ../references)
```

## Code Generation

### Prerequisites

- .NET 8 SDK.
- The API specification file: `aspose.cells.cloud.specification.json`.
- Generation scripts in the project root.

All three scripts are deterministic and idempotent. Each **deletes stale generated files** (models /
requests / tests that disappeared from the spec or `TestingData/` since the last run) so the generated
tree never accumulates orphans.

### Generate Models

```bash
python generate_models.py
```

Reads the `Models` array and generates one `.cs` per class model under `Aspose.Cells.Cloud/Model/`. Each
model follows [references/model_generation_rules.md](../references/model_generation_rules.md). Spec
descriptions that are LLM-authored placeholder text (e.g. *"I'm here to help! Please provide me with the
features…"*) are detected and replaced with a fallback doc comment, so the generated XML docs stay
meaningful.

### Generate Requests

```bash
python generate_requests.py
```

Reads the `Operations` array and generates one request class per operation under
`Aspose.Cells.Cloud/Request/`, following [references/request_generation_rules.md](../references/request_generation_rules.md).

### Generate Tests

```bash
python generate_tests.py
```

Reads `TestingData/` JSON files and generates xUnit cases under `Aspose.Cells.Cloud.Tests/`, following
[references/test_generation_rules.md](../references/test_generation_rules.md). The script wipes only
**top-level** `*.cs` in the test project; hand-written tests live in `Aspose.Cells.Cloud.Tests/Manual/` and
survive regeneration.

## Type Mapping

| Spec `DataType.Identifier` | Go type | C# type |
|----------------------------|---------|---------|
| `String` | `string` | `string` |
| `Boolean` | `*bool` | `bool?` |
| `Integer` | `*int32` | `int?` |
| `Long` | `*int64` | `long?` |
| `Floating` | `*float64` | `double?` |
| `DateTime` | `time.Time` | `DateTime` (ISO 8601) |
| `Byte` | `byte` | `byte?` (single 0–255 value, e.g. a `Color` RGBA channel) |
| `Array<Byte>` | `[]byte` | `byte[]?` (binary blob) |
| `Class` (Reference) | `*Ref` | `Ref` (reference type, `null` = absent) |
| `Container` (Reference) | `[]Ref` | `List<Ref>` |
| `Array` (ElementDataType) | `[]T` | `List<T>` |
| `File` (formData) | multipart file part | `FileParameter` (path / stream / bytes) |
| `Object` / `Any` | `map[string]interface{}` / `interface{}` | `Dictionary<string, object>` / `object` |

> **Nullability is explicit in C#.** Nullable value types (`int?`, `bool?`, `double?`, `long?`) and
> nullable reference types (`string?`, `Type?`) default to `null`, which is omitted from JSON output via
> `JsonIgnoreCondition.WhenWritingNull` — reproducing the Go SDK's `omitempty` with no pointer helpers.

## Key Design Patterns

### Request Interface

Every request class implements `IRequestOption`:

```csharp
namespace Aspose.Cells.Cloud;

public interface IRequestOption
{
    string GetMethod();                                 // GET/POST/PUT/DELETE
    string GetPath();                                   // {param} already substituted
    Dictionary<string, string> GetQueryParameters();    // string => string
    Dictionary<string, string> GetHeaderParameters();   // string => string
    object? GetJsonBody();                              // null when no body
    Dictionary<string, object>? GetMultipartForm();     // null when no form
}
```

### Client

`AsposeCellsCloudClient` owns a `Configuration` and an `HttpClient`, authenticates via OAuth2
client-credentials, and is **`IDisposable`** (dispose it to release the connection pool):

```csharp
using var client = new AsposeCellsCloudClient(clientId, clientSecret, baseUrl);
// Test/custom transport: new AsposeCellsCloudClient(myHandler, clientId, clientSecret, baseUrl);
```

- **Timeout** (`Configuration.Timeout`, default 120s) is applied **per request** at call time via a linked
  `CancellationTokenSource`, so it can be changed after construction and it also bounds the OAuth token
  request. Set to `TimeSpan.Zero` for no timeout.
- **Retries** (`Configuration.Retries`, default 0) retry only *transient* transport failures
  (`HttpRequestException`, or the per-call timeout) with exponential backoff (500ms, 1s, 2s, … capped at
  8s). Deterministic HTTP errors (4xx/5xx → `SDKException`) and caller-supplied cancellation are never
  retried. `FileParameter.FromStream` must be seekable when retries are enabled (each retry rewinds a
  seekable stream; `FromPath`/`FromBytes` are always retry-safe).
- The access token is cached and refreshed under a `SemaphoreSlim` double-checked lock, so concurrent
  `DoAsync` calls share one token fetch.
- Execution: `Do` / `DoAsync` for a single request, `DoBatch` / `DoBatchAsync` for sequential batches.

### Required & Optional Parameters

Required parameters are constructor arguments, validated in the constructor (the Go SDK's analog: its
constructors never return nil; missing required params are rejected by `Validate()` at execution time).
Optional parameters are settable properties set via an object initializer:

```csharp
var request = new PostClearContentsRequest("Book1.xlsx", "Sheet1")
{
    Range = "A1:C10",        // optional
    Folder = "TestData/In",  // optional
};
```

This mirrors the Go SDK's `NewXxxRequest(required..., opts...)` / `WithCommonParameter` pattern with C#'s
constructor + object-initializer idiom — no fluent setter chain.

### File Uploads (`FileParameter`)

FormData file parameters accept `FileParameter`, which can back its content from a local path, an
in-memory `Stream`, or raw bytes — and a plain `string` path converts implicitly:

```csharp
// local path (implicit conversion keeps the old call-site working)
new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx");

// stream / bytes
new UploadFileRequest(FileParameter.FromStream(stream, "Book1.xlsx"), "TestData/In/Book1.xlsx");
new UploadFileRequest(FileParameter.FromBytes(bytes, "Book1.xlsx"), "TestData/In/Book1.xlsx");
```

The client builds a `multipart/form-data` body from `GetMultipartForm()`; the part is named
`"@" + FileParameter.FileName`.

### Parameter Type Rules

| Parameter Type | Required | Optional |
|---------------|----------|----------|
| string | `string` (validated non-empty) | `string?` (null/empty = omitted) |
| integer / boolean / floating | `int` / `bool` / `double` (validated) | `int?` / `bool?` / `double?` (null = omitted) |
| Class | `Type` (validated non-null) | `Type?` (null = omitted) |
| Container / Array | `List<T>` | `List<T>?` |
| File | `FileParameter` (validated non-null) | `FileParameter?` (null = omitted) |

### Model Serialization

Models use `[JsonPropertyName("WireName")]` per property; null fields are omitted globally via the
client's `JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull`. See
[references/model_generation_rules.md](../references/model_generation_rules.md).

## Adding New APIs

1. Add the operation (and any new models) to `aspose.cells.cloud.specification.json`.
2. Run `python generate_models.py` to (re)generate model classes.
3. Run `python generate_requests.py` to (re)generate request classes.
4. Add test data to `TestingData/` and run `python generate_tests.py`.
5. Build and test:

```bash
dotnet build
dotnet test
```

## Contributing

1. Follow the naming and layout conventions in `CLAUDE.md`.
2. Models use auto-properties + `[JsonPropertyName]`.
3. Requests implement `IRequestOption`; validate required constructor args.
4. Throw `SDKException` for HTTP failures, `ArgumentException`/`ArgumentNullException` for bad local
   input — never a raw `Exception`.
5. Run `dotnet build -warnaserror` and `dotnet test` before submitting changes.
