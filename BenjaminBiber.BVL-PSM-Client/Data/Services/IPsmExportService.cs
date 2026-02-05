using BenjaminBiber.BVL_PSM_Client.Data.Models;

namespace BenjaminBiber.BVL_PSM_Client.Data.Services;

public interface IPsmExportService
{
    Task<IReadOnlyList<MittelAggregate>> LoadAggregatedAsync(
        IProgress<ExportProgress>? progress,
        CancellationToken cancellationToken);
    Task<string> BuildCsvAsync(IReadOnlyList<string> selectedColumnIds, CancellationToken cancellationToken);
}

public sealed record ExportProgress(string Stage, int Completed, int Total);
