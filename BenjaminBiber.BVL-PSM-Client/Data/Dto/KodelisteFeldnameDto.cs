using System.Text.Json.Serialization;

namespace BenjaminBiber.BVL_PSM_Client.Data.Dto;

public sealed class KodelisteFeldnameDto
{
    [JsonPropertyName("tabellenname")]
    public string? Tabellenname { get; init; }

    [JsonPropertyName("feldname")]
    public string? Feldname { get; init; }

    [JsonPropertyName("kodeliste")]
    public int? Kodeliste { get; init; }
}
