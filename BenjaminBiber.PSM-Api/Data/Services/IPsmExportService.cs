using BenjaminBiber.PSM_Api.Data.Models;

namespace BenjaminBiber.PSM_Api.Data.Services;

public interface IPsmExportService
{
    Task<IReadOnlyList<MittelAggregate>> LoadAggregatedAsync(
        IProgress<ExportProgress>? progress,
        CancellationToken cancellationToken);
    Task<string> BuildCsvAsync(IReadOnlyList<string> selectedColumnIds, CancellationToken cancellationToken);
}

public sealed record ExportProgress(string Stage, int Completed, int Total);
