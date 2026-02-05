using System.Collections.Concurrent;
using BenjaminBiber.BVL_PSM_Client.Data.Clients;
using BenjaminBiber.BVL_PSM_Client.Data.Models;

namespace BenjaminBiber.BVL_PSM_Client.Data.Services;

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
