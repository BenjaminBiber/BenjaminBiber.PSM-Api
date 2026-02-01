using System.Text.Json.Serialization;

namespace BenjaminBiber.PSM_Api.Data.Dto;

public sealed class KodelisteFeldnameDto
{
    [JsonPropertyName("tabellenname")]
    public string? Tabellenname { get; init; }

    [JsonPropertyName("feldname")]
    public string? Feldname { get; init; }

    [JsonPropertyName("kodeliste")]
    public int? Kodeliste { get; init; }
}
