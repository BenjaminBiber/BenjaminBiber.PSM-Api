using System.Text.Json.Serialization;

namespace BenjaminBiber.PSM_Api.Data.Dto;

public sealed class WirkstoffDto
{
    [JsonPropertyName("wirknr")]
    public string? WirkNr { get; init; }

    [JsonPropertyName("wirkstoffname")]
    public string? Wirkstoffname { get; init; }
}
