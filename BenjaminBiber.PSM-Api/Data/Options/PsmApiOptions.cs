namespace BenjaminBiber.PSM_Api.Data.Options;

public sealed class PsmApiOptions
{
    public string BaseUrl { get; init; } = "https://psm-api.bvl.bund.de/ords/psm/api-v1/";
    public int PageSize { get; init; } = 1000;
    public string LanguageCode { get; init; } = "DE";
}
