# BenjaminBiber.BVL-PSM-Client

A .NET client for the BVL PSM ORDS API plus small export helpers. It wraps the official endpoints, adds paging, and provides a convenience aggregation for "Mittel" data.

## Install

```bash
dotnet add package BenjaminBiber.BVL-PSM-Client
```

## Quick start

Register the HTTP client and options:

```csharp
using BenjaminBiber.BVL_PSM_Client;
using BenjaminBiber.BVL_PSM_Client.Data.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPsmApiClients(options =>
{
    options.BaseUrl = "https://psm-api.bvl.bund.de/ords/psm/api-v1/";
    options.PageSize = 1000;
    options.LanguageCode = "DE";
});
```

Or bind from configuration:

```json
{
  "PsmApi": {
    "BaseUrl": "https://psm-api.bvl.bund.de/ords/psm/api-v1/",
    "PageSize": 1000,
    "LanguageCode": "DE"
  }
}
```

```csharp
builder.Services.AddPsmApiClients(options =>
    builder.Configuration.GetSection("PsmApi").Bind(options));
```

## Usage

### Raw API access

Inject `IPsmApiClient` and call any endpoint. Many endpoints return `JsonElement` because the schema can vary.

```csharp
using BenjaminBiber.BVL_PSM_Client.Data.Clients;

public sealed class MyService(IPsmApiClient client)
{
    public Task<IReadOnlyList<MittelDto>> LoadAllMittelAsync(CancellationToken ct)
        => client.GetAllMittelAsync(ct);
}
```

### Aggregated "Mittel" data

The aggregation loads Mittel, Wirkstoffe, and AWG data and merges it into a single model.

```csharp
var data = await client.GetAggregatedMittelAsync(progress: null, cancellationToken);
```

### CSV export helpers

The package ships simple helpers for CSV export. Register them manually:

```csharp
using BenjaminBiber.BVL_PSM_Client.Data.Services;

builder.Services.AddSingleton<ExportColumnRegistry>();
builder.Services.AddSingleton<CsvBuilder>();
builder.Services.AddScoped<IPsmExportService, PsmExportService>();
```

Then build CSV output:

```csharp
var csv = await exportService.BuildCsvAsync(columnIds, cancellationToken);
```

## Options

`PsmApiOptions`:
- `BaseUrl` (default: `https://psm-api.bvl.bund.de/ords/psm/api-v1/`)
- `PageSize` (default: `1000`)
- `LanguageCode` (default: `DE`) used for `DeKodeAsync`

## Notes

- The client uses `HttpClientFactory` with name `PsmApi`.
- All calls are async and accept `CancellationToken`.
- The ORDS API is public and does not require auth.

## License

MIT
