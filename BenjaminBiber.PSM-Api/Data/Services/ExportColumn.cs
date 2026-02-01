using BenjaminBiber.PSM_Api.Data.Models;

namespace BenjaminBiber.PSM_Api.Data.Services;

public sealed record ExportColumn(
    string Id,
    string Label,
    Func<MittelAggregate, string?> ValueSelector);
