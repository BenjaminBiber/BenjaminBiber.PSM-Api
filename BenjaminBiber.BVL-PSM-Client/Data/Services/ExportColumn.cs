using BenjaminBiber.BVL_PSM_Client.Data.Models;

namespace BenjaminBiber.BVL_PSM_Client.Data.Services;

public sealed record ExportColumn(
    string Id,
    string Label,
    Func<MittelAggregate, string?> ValueSelector);
