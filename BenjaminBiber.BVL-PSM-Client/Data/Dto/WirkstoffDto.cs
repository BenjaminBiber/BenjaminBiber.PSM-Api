using System.Text.Json.Serialization;

namespace BenjaminBiber.BVL_PSM_Client.Data.Dto;

public sealed class WirkstoffDto
{
    [JsonPropertyName("wirknr")]
    public string? WirkNr { get; init; }

    [JsonPropertyName("wirkstoffname")]
    public string? Wirkstoffname { get; init; }
}
