using System.Text.Json.Serialization;

namespace BenjaminBiber.PSM_Api.Data.Dto;

public sealed class AwgDto
{
    [JsonPropertyName("awg_id")]
    public string? AwgId { get; init; }

    [JsonPropertyName("kennr")]
    public string? Kennr { get; init; }
}
