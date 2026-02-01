using System.Collections.Concurrent;
using BenjaminBiber.PSM_Api.Data.Clients;
using BenjaminBiber.PSM_Api.Data.Models;

namespace BenjaminBiber.PSM_Api.Data.Services;

public sealed class PsmExportService(
    IPsmApiClient apiClient,
    CsvBuilder csvBuilder) : IPsmExportService
{
    public async Task<IReadOnlyList<MittelAggregate>> LoadAggregatedAsync(
        IProgress<ExportProgress>? progress,
        CancellationToken cancellationToken)
    {
        return await apiClient.GetAggregatedMittelAsync(progress, cancellationToken);
    }

    public async Task<string> BuildCsvAsync(IReadOnlyList<string> selectedColumnIds, CancellationToken cancellationToken)
    {
        var aggregates = await LoadAggregatedAsync(null, cancellationToken);
        return csvBuilder.BuildCsv(aggregates, selectedColumnIds);
    }

}
