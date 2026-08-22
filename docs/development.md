# Development Guide

## Project Overview

This SDK is generated from `aspose.cells.cloud.specification.json` (461 operations, 42 controllers,
483 data models) and mirrors the structure of the Aspose.Cells Cloud SDK for Go, translated to C#.

## Directory Structure

```
cells-cloud-sdk-net/
├── Aspose.Cells.Cloud.sln                 # solution
├── README.md                              # top-level readme
├── Aspose.Cells.Cloud/
│   ├── Aspose.Cells.Cloud.csproj          # SDK library project
│   ├── AsposeCellsCloudClient.cs
│   ├── Configuration.cs
│   ├── IRequestOption.cs                  # interface
│   ├── RichResponse.cs
│   ├── SDKException.cs
│   ├── Version.cs
│   ├── Model/                             # 451 model classes
│   └── Request/                           # 457 request classes
├── Aspose.Cells.Cloud.Tests/              # xUnit integration test project (47 classes / 484 cases; Manual/ holds hand-written tests)
├── TestingData/                           # JSON test-case configuration
├── testdata/                              # sample XLSX / CSV files
├── aspose.cells.cloud.specification.json  # API specification (source of truth)
├── generate_models.py                     # model generation script
├── generate_requests.py                   # request generation script
├── generate_tests.py                      # test generation script
├── docs/                                  # guides (api_reference, development, testing)
└── references/                            # generation rules (see ../references)
```

## Code Generation

### Prerequisites

- .NET 8 SDK.
- The API specification file: `aspose.cells.cloud.specification.json`.
- Generation scripts in the project root.

### Generate Models

```bash
python generate_models.py
```

Reads the `Models` array and generates one `.cs` per model under `Aspose.Cells.Cloud/Model/`. Each
model follows [references/model_generation_rules.md](../references/model_generation_rules.md).

### Generate Requests

```bash
python generate_requests.py
```

Reads the `Operations` array and generates one request class per operation under
`Aspose.Cells.Cloud/Request/`, following
[references/request_generation_rules.md](../references/request_generation_rules.md).

### Generate Tests

```bash
python generate_tests.py
```

Reads `TestingData/` JSON files and generates xUnit cases under `Aspose.Cells.Cloud.Tests/`, following
[references/test_generation_rules.md](../references/test_generation_rules.md).

## Type Mapping

| Spec `DataType.Identifier` | Go type | C# type |
|----------------------------|---------|---------|
| `String` | `string` | `string` |
| `Boolean` | `*bool` | `bool?` |
| `Integer` | `*int32` | `int?` |
| `Long` | `*int64` | `long?` |
| `Floating` | `*float64` | `double?` |
| `DateTime` | `time.Time` | `DateTime` (ISO 8601) |
| `Byte` | `byte` | `byte?` |
| `Class` (Reference) | `*Ref` | `Ref` |
| `Container` (Reference) | `[]Ref` | `List<Ref>` |
| `Array` (ElementDataType) | `[]T` | `List<T>` |
| `Object` / `Any` | `map[string]interface{}` / `interface{}` | `Dictionary<string, object>` / `object` |

> `Byte` maps to a single `byte?` (a 0–255 value, e.g. a `Color` RGBA channel). Binary blobs would be
> `Array<Byte>` → `byte[]`; none occur in the current specification.

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
    object GetJsonBody();                               // null when no body
    Dictionary<string, object> GetMultipartForm();      // null/empty when no form
}
```

### Required & Optional Parameters

Required parameters are constructor arguments, validated in the constructor (the analog of the Go SDK
returning `nil` on a missing required arg). Optional parameters are settable properties set via an
object initializer:

```csharp
var request = new PostClearContentsRequest("Book1.xlsx", "Sheet1")
{
    Range = "A1:C10",        // optional
    Folder = "TestData/In",  // optional
};
```

This mirrors the Go SDK's `NewXxxRequest(required..., opts...)` / `WithCommonParameter` pattern with
C#'s constructor + object-initializer idiom — no fluent setter chain.

### Parameter Type Rules

| Parameter Type | Required | Optional |
|---------------|----------|----------|
| string | `string` (validated non-empty) | `string?` (null/empty = omitted) |
| integer / boolean / floating | `int` / `bool` / `double` (validated) | `int?` / `bool?` / `double?` (null = omitted) |
| Class | `Type` (validated non-null) | `Type?` (null = omitted) |
| Container / Array | `List<T>` | `List<T>?` |
| File (formData) | `FileParameter` (validated non-null) | `FileParameter?` (null = omitted) |

### File Uploads (`FileParameter`)

`formData` file parameters are typed as `FileParameter`, which accepts a local path, a `Stream`, or raw
bytes:

```csharp
new UploadFileRequest("testdata/Book1.xlsx", "TestData/In/Book1.xlsx");          // path (implicit)
new UploadFileRequest(FileParameter.FromStream(stream, "Book1.xlsx"), "dest");    // stream
new UploadFileRequest(FileParameter.FromBytes(bytes, "Book1.xlsx"), "dest");      // bytes
```

A plain `string` converts implicitly to a path-backed `FileParameter`, so existing call sites keep
working. The client streams file content (`StreamContent`) instead of buffering it entirely in memory;
the caller-supplied stream is disposed after the request. See
[references/request_generation_rules.md](../references/request_generation_rules.md).

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
