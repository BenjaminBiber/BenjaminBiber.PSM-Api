namespace BenjaminBiber.PSM_Api.Data.Models;

public sealed class WirkstoffInfo
{
    public required string Wirkstoff { get; init; }
    public string? Gehalt { get; init; }
    public string? Einheit { get; init; }
}
