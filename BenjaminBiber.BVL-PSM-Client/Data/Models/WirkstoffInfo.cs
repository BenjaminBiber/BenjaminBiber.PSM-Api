namespace BenjaminBiber.BVL_PSM_Client.Data.Models;

public sealed class WirkstoffInfo
{
    public required string Wirkstoff { get; init; }
    public string? Gehalt { get; init; }
    public string? Einheit { get; init; }
}
