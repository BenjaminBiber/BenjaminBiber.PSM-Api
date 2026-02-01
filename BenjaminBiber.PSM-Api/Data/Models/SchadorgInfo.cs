namespace BenjaminBiber.PSM_Api.Data.Models;

public sealed class SchadorgInfo
{
    public required string Kode { get; init; }
    public string? Text { get; init; }
    public List<string> Gruppen { get; init; } = [];
}
