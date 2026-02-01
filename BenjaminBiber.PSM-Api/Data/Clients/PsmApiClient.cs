using System.Collections.Concurrent;
using System.Net;
using System.Text.Json;
using Microsoft.Extensions.Options;
using BenjaminBiber.PSM_Api.Data.Dto;
using BenjaminBiber.PSM_Api.Data.Models;
using BenjaminBiber.PSM_Api.Data.Options;
using BenjaminBiber.PSM_Api.Data.Services;

namespace BenjaminBiber.PSM_Api.Data.Clients;

public interface IPsmApiClient
{
    Task<string?> DeKodeAsync(string kode, CancellationToken cancellationToken);
    Task<IReadOnlyList<MittelAggregate>> GetAggregatedMittelAsync(
        IProgress<ExportProgress>? progress,
        CancellationToken cancellationToken);
    Task<IReadOnlyList<AwgDto>> GetAllAwgAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<AwgDto>> GetAwgAsync(string? awgId, string? kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<AwgDto>> GetAwgByIdAsync(string awgId, string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<AwgSchadorgDto>> GetAllAwgSchadorgAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<AwgSchadorgDto>> GetAwgSchadorgByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<AwgSchadorgDto>> GetAwgSchadorgByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<KodeDto>> GetAllKodeAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<KodeDto>> GetKodeAsync(string kode, CancellationToken cancellationToken);
    Task<IReadOnlyList<KodeDto>> GetKodeAsync(string? kode, string? kodeliste, string? sprache, CancellationToken cancellationToken);
    Task<IReadOnlyList<KodeDto>> GetKodeByIdAsync(string kode, string kodeliste, string sprache, CancellationToken cancellationToken);
    Task<IReadOnlyList<KodelisteFeldnameDto>> GetAllKodelisteFeldnameAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<KodelisteFeldnameDto>> GetFeldnameMappingsAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<KodelisteFeldnameDto>> GetKodelisteFeldnameAsync(string? feldname, string? kodeliste, string? tabelle, CancellationToken cancellationToken);
    Task<IReadOnlyList<KodelisteFeldnameDto>> GetKodelisteFeldnameByIdAsync(string feldname, string kodeliste, string tabelle, CancellationToken cancellationToken);
    Task<IReadOnlyList<MittelDto>> GetAllMittelAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<MittelDto>> GetMittelByKennrAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<MittelDto>> GetMittelByIdAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<WirkstoffDto>> GetAllWirkstoffAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<WirkstoffDto>> GetWirkstoffByWirknrAsync(string wirknr, CancellationToken cancellationToken);
    Task<IReadOnlyList<WirkstoffDto>> GetWirkstoffByIdAsync(string wirknr, CancellationToken cancellationToken);
    Task<IReadOnlyList<WirkstoffGehaltDto>> GetAllWirkstoffGehaltAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<WirkstoffGehaltDto>> GetWirkstoffGehaltAsync(string? kennr, string? wirknr, CancellationToken cancellationToken);
    Task<IReadOnlyList<WirkstoffGehaltDto>> GetWirkstoffGehaltByIdAsync(string kennr, string wirknr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAdresseAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAdresseByAdresseNrAsync(string adresseNr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAdresseByIdAsync(string adresseNr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAntragAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAntragAsync(string? antragnr, string? antragstellerNr, string? kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAntragByIdAsync(string antragnr, string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAuflageReduAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAuflageReduByAuflagenrAsync(string auflagenr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAuflageReduByIdAsync(string auflagenr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAuflagenAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAuflagenAsync(string? auflage, string? auflagenr, string? ebene, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAuflagenByIdAsync(string auflage, string auflagenr, string ebene, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgAufwandAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgAufwandByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgAufwandByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgBemAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgBemByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgBemByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgKulturAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgKulturByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgKulturByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgPartnerAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgPartnerByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgPartnerByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgPartnerAufwandAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgPartnerAufwandByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgPartnerAufwandByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgVerwendungszweckAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgVerwendungszweckByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgVerwendungszweckByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgWartezeitAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgWartezeitAsync(string? awgId, string? awgWartezeitNr, string? kultur, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgWartezeitByIdAsync(string awgId, string awgWartezeitNr, string kultur, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgWartezeitAusgKulturAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgWartezeitAusgKulturAsync(string? awgWartezeitNr, string? kultur, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgWartezeitAusgKulturByIdAsync(string awgWartezeitNr, string kultur, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgZeitpunktAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgZeitpunktByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgZeitpunktByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllAwgZulassungAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgZulassungByAwgIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAwgZulassungByIdAsync(string awgId, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllGhsGefahrenhinweiseAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetGhsGefahrenhinweiseByKennrAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetGhsGefahrenhinweiseByIdAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllGhsGefahrensymboleAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetGhsGefahrensymboleByKennrAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetGhsGefahrensymboleByIdAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllGhsSicherheitshinweiseAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetGhsSicherheitshinweiseByKennrAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetGhsSicherheitshinweiseByIdAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllGhsSignalwoerterAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetGhsSignalwoerterByKennrAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetGhsSignalwoerterByIdAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllHinweisAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetHinweisByEbeneAsync(string ebene, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetHinweisByIdAsync(string ebene, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllKodelisteAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetKodelisteByKodelisteAsync(string kodeliste, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetKodelisteByIdAsync(string kodeliste, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllKulturGruppeAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetKulturGruppeAsync(string? kultur, string? kulturGruppe, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetKulturGruppeByIdAsync(string kultur, string kulturGruppe, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllMittelAbgelaufenAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelAbgelaufenByKennrAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelAbgelaufenByIdAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllMittelAbpackungAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelAbpackungByKennrAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelAbpackungByIdAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllMittelGefahrenSymbolAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelGefahrenSymbolByKennrAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelGefahrenSymbolByIdAsync(string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllMittelVertriebAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelVertriebAsync(string? kennr, string? vertriebsfirmaNr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelVertriebByIdAsync(string kennr, string vertriebsfirmaNr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllMittelWirkbereichAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelWirkbereichAsync(string? kennr, string? wirkungsbereich, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetMittelWirkbereichByIdAsync(string kennr, string wirkungsbereich, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllParallelimportAbgelaufenAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetParallelimportAbgelaufenAsync(string? importeurNr, string? piReferenzKennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetParallelimportAbgelaufenByIdAsync(string importeurNr, string piReferenzKennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllParallelimportGueltigAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetParallelimportGueltigAsync(string? importeurNr, string? piReferenzKennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetParallelimportGueltigByIdAsync(string importeurNr, string piReferenzKennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllSchadorgGruppeAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetSchadorgGruppeAsync(string? schadorg, string? schadorgGruppe, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetSchadorgGruppeByIdAsync(string schadorg, string schadorgGruppe, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllStaerkungAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetStaerkungAsync(string? antragstellerNr, string? kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetStaerkungByIdAsync(string antragstellerNr, string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllStaerkungVertriebAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetStaerkungVertriebAsync(string? kennr, string? vertriebsfirmaNr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetStaerkungVertriebByIdAsync(string kennr, string vertriebsfirmaNr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllStandAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllZusatzstoffAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetZusatzstoffAsync(string? antragstellerNr, string? kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetZusatzstoffByIdAsync(string antragstellerNr, string kennr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetAllZusatzstoffVertriebAsync(CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetZusatzstoffVertriebAsync(string? kennr, string? vertriebsfirmaNr, CancellationToken cancellationToken);
    Task<IReadOnlyList<JsonElement>> GetZusatzstoffVertriebByIdAsync(string kennr, string vertriebsfirmaNr, CancellationToken cancellationToken);
}

public sealed class PsmApiClient(IHttpClientFactory httpClientFactory, IOptions<PsmApiOptions> options) : IPsmApiClient
{
    private const string ClientName = "PsmApi";
    private readonly ConcurrentDictionary<string, Lazy<Task<string?>>> _kodeCache = new(StringComparer.OrdinalIgnoreCase);
    private readonly string _languageCode = string.IsNullOrWhiteSpace(options.Value.LanguageCode)
        ? "DE"
        : options.Value.LanguageCode;

    private HttpClient CreateClient() => httpClientFactory.CreateClient(ClientName);

    public Task<string?> DeKodeAsync(string kode, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(kode))
        {
            return Task.FromResult<string?>(null);
        }

        var key = kode.Trim();
        var lazy = _kodeCache.GetOrAdd(
            key,
            cachedKey => new Lazy<Task<string?>>(() => LoadKodeTextAsync(cachedKey, CancellationToken.None)));

        return AwaitWithCancellationAsync(lazy.Value, cancellationToken);
    }

    public async Task<IReadOnlyList<MittelAggregate>> GetAggregatedMittelAsync(
        IProgress<ExportProgress>? progress,
        CancellationToken cancellationToken)
    {
        progress?.Report(new ExportProgress("Lade Mittel", 0, 0));
        var mittelDtos = await GetAllMittelAsync(cancellationToken);

        progress?.Report(new ExportProgress("Lade Wirkstoffe", 0, 0));
        var wirkstoffDtos = await GetAllWirkstoffAsync(cancellationToken);
        var wirkstoffGehaltDtos = await GetAllWirkstoffGehaltAsync(cancellationToken);

        progress?.Report(new ExportProgress("Lade AWG-Daten", 0, 0));
        var awgDtos = await GetAllAwgAsync(cancellationToken);
        var awgSchadorgDtos = await GetAllAwgSchadorgAsync(cancellationToken);

        var wirkstoffLookup = wirkstoffDtos
            .Where(dto => !string.IsNullOrWhiteSpace(dto.WirkNr))
            .ToDictionary(dto => dto.WirkNr!, dto => dto.Wirkstoffname ?? dto.WirkNr!, StringComparer.OrdinalIgnoreCase);

        var wirkstoffByKennr = wirkstoffGehaltDtos
            .Where(dto => !string.IsNullOrWhiteSpace(dto.Kennr))
            .GroupBy(dto => dto.Kennr!, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(
                group => group.Key,
                group => group
                    .Select(item => new WirkstoffInfo
                    {
                        Wirkstoff = ResolveWirkstoffName(wirkstoffLookup, item),
                        Gehalt = ResolveWirkstoffGehalt(item),
                        Einheit = item.GehaltEinheit
                    })
                    .ToList(),
                StringComparer.OrdinalIgnoreCase);

        var awgByKennr = awgDtos
            .Where(dto => !string.IsNullOrWhiteSpace(dto.Kennr))
            .GroupBy(dto => dto.Kennr!, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(group => group.Key, group => group.ToList(), StringComparer.OrdinalIgnoreCase);

        var schadorgByAwgId = awgSchadorgDtos
            .Where(dto => !string.IsNullOrWhiteSpace(dto.AwgId))
            .GroupBy(dto => dto.AwgId!, StringComparer.OrdinalIgnoreCase)
            .ToDictionary(group => group.Key, group => group.ToList(), StringComparer.OrdinalIgnoreCase);

        var aggregates = new ConcurrentBag<MittelAggregate>();
        using var limiter = new SemaphoreSlim(8);
        var total = mittelDtos.Count(dto => !string.IsNullOrWhiteSpace(dto.Kennr));
        var completed = 0;
        progress?.Report(new ExportProgress("Lade Daten", 0, total));

        var tasks = mittelDtos.Select(async mittel =>
        {
            if (string.IsNullOrWhiteSpace(mittel.Kennr))
            {
                return;
            }

            await limiter.WaitAsync(cancellationToken);
            try
            {
                var kennr = mittel.Kennr.Trim();
                awgByKennr.TryGetValue(kennr, out var awgs);
                var schadorgCodes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                if (awgs is not null)
                {
                    foreach (var awg in awgs)
                    {
                        if (string.IsNullOrWhiteSpace(awg.AwgId))
                        {
                            continue;
                        }

                        if (!schadorgByAwgId.TryGetValue(awg.AwgId.Trim(), out var schadorgs))
                        {
                            continue;
                        }

                        foreach (var schadorg in schadorgs)
                        {
                            if (!string.IsNullOrWhiteSpace(schadorg.Schadorg))
                            {
                                schadorgCodes.Add(schadorg.Schadorg.Trim());
                            }
                        }
                    }
                }

                var schadorgInfos = await DecodeSchadorgAsync(schadorgCodes, cancellationToken);
                wirkstoffByKennr.TryGetValue(kennr, out var wirkstoffe);

                aggregates.Add(new MittelAggregate
                {
                    Kennr = kennr,
                    Name = ResolveMittelName(mittel),
                    ZulassungVon = ParseDate(ResolveMittelZulassungVon(mittel)),
                    ZulassungBis = ParseDate(ResolveMittelZulassungBis(mittel)),
                    Wirkstoffe = wirkstoffe ?? [],
                    Schadorganismen = schadorgInfos
                });
            }
            finally
            {
                if (!string.IsNullOrWhiteSpace(mittel.Kennr))
                {
                    var current = Interlocked.Increment(ref completed);
                    progress?.Report(new ExportProgress("Lade Daten", current, total));
                }
                limiter.Release();
            }
        }).ToList();

        await Task.WhenAll(tasks);

        return aggregates.OrderBy(item => item.Kennr, StringComparer.OrdinalIgnoreCase).ToList();
    }

    public Task<IReadOnlyList<AwgDto>> GetAllAwgAsync(CancellationToken cancellationToken)
        => GetAllAsync<AwgDto>("awg/", null, cancellationToken);

    public Task<IReadOnlyList<AwgDto>> GetAwgAsync(string? awgId, string? kennr, CancellationToken cancellationToken)
        => GetAllAsync<AwgDto>("awg/", new Dictionary<string, string?>
        {
            ["awg_id"] = awgId,
            ["kennr"] = kennr,
        }, cancellationToken);

    public Task<IReadOnlyList<AwgDto>> GetAwgByIdAsync(string awgId, string kennr, CancellationToken cancellationToken)
        => GetAwgAsync(awgId, kennr, cancellationToken);
    public Task<IReadOnlyList<AwgSchadorgDto>> GetAllAwgSchadorgAsync(CancellationToken cancellationToken)
        => GetAllAsync<AwgSchadorgDto>("awg_schadorg/", null, cancellationToken);

    public Task<IReadOnlyList<AwgSchadorgDto>> GetAwgSchadorgByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<AwgSchadorgDto>("awg_schadorg/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<AwgSchadorgDto>> GetAwgSchadorgByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgSchadorgByAwgIdAsync(awgId, cancellationToken);
    public Task<IReadOnlyList<KodeDto>> GetAllKodeAsync(CancellationToken cancellationToken)
        => GetAllAsync<KodeDto>("kode/", null, cancellationToken);

    public Task<IReadOnlyList<KodeDto>> GetKodeAsync(string kode, CancellationToken cancellationToken)
        => GetKodeAsync(kode, null, null, cancellationToken);

    public Task<IReadOnlyList<KodeDto>> GetKodeAsync(string? kode, string? kodeliste, string? sprache, CancellationToken cancellationToken)
        => GetAllAsync<KodeDto>("kode/", new Dictionary<string, string?>
        {
            ["kode"] = kode,
            ["kodeliste"] = kodeliste,
            ["sprache"] = sprache,
        }, cancellationToken);

    public Task<IReadOnlyList<KodeDto>> GetKodeByIdAsync(string kode, string kodeliste, string sprache, CancellationToken cancellationToken)
        => GetKodeAsync(kode, kodeliste, sprache, cancellationToken);
    public Task<IReadOnlyList<KodelisteFeldnameDto>> GetAllKodelisteFeldnameAsync(CancellationToken cancellationToken)
        => GetAllAsync<KodelisteFeldnameDto>("kodeliste_feldname/", null, cancellationToken);

    public Task<IReadOnlyList<KodelisteFeldnameDto>> GetFeldnameMappingsAsync(CancellationToken cancellationToken)
        => GetAllKodelisteFeldnameAsync(cancellationToken);

    public Task<IReadOnlyList<KodelisteFeldnameDto>> GetKodelisteFeldnameAsync(string? feldname, string? kodeliste, string? tabelle, CancellationToken cancellationToken)
        => GetAllAsync<KodelisteFeldnameDto>("kodeliste_feldname/", new Dictionary<string, string?>
        {
            ["feldname"] = feldname,
            ["kodeliste"] = kodeliste,
            ["tabelle"] = tabelle,
        }, cancellationToken);

    public Task<IReadOnlyList<KodelisteFeldnameDto>> GetKodelisteFeldnameByIdAsync(string feldname, string kodeliste, string tabelle, CancellationToken cancellationToken)
        => GetKodelisteFeldnameAsync(feldname, kodeliste, tabelle, cancellationToken);
    public Task<IReadOnlyList<MittelDto>> GetAllMittelAsync(CancellationToken cancellationToken)
        => GetAllAsync<MittelDto>("mittel/", null, cancellationToken);

    public Task<IReadOnlyList<MittelDto>> GetMittelByKennrAsync(string kennr, CancellationToken cancellationToken)
        => GetAllAsync<MittelDto>("mittel/", new Dictionary<string, string?> { ["kennr"] = kennr }, cancellationToken);

    public Task<IReadOnlyList<MittelDto>> GetMittelByIdAsync(string kennr, CancellationToken cancellationToken)
        => GetMittelByKennrAsync(kennr, cancellationToken);
    public Task<IReadOnlyList<WirkstoffDto>> GetAllWirkstoffAsync(CancellationToken cancellationToken)
        => GetAllAsync<WirkstoffDto>("wirkstoff/", null, cancellationToken);

    public Task<IReadOnlyList<WirkstoffDto>> GetWirkstoffByWirknrAsync(string wirknr, CancellationToken cancellationToken)
        => GetAllAsync<WirkstoffDto>("wirkstoff/", new Dictionary<string, string?> { ["wirknr"] = wirknr }, cancellationToken);

    public Task<IReadOnlyList<WirkstoffDto>> GetWirkstoffByIdAsync(string wirknr, CancellationToken cancellationToken)
        => GetWirkstoffByWirknrAsync(wirknr, cancellationToken);
    public Task<IReadOnlyList<WirkstoffGehaltDto>> GetAllWirkstoffGehaltAsync(CancellationToken cancellationToken)
        => GetAllAsync<WirkstoffGehaltDto>("wirkstoff_gehalt/", null, cancellationToken);

    public Task<IReadOnlyList<WirkstoffGehaltDto>> GetWirkstoffGehaltAsync(string? kennr, string? wirknr, CancellationToken cancellationToken)
        => GetAllAsync<WirkstoffGehaltDto>("wirkstoff_gehalt/", new Dictionary<string, string?>
        {
            ["kennr"] = kennr,
            ["wirknr"] = wirknr,
        }, cancellationToken);

    public Task<IReadOnlyList<WirkstoffGehaltDto>> GetWirkstoffGehaltByIdAsync(string kennr, string wirknr, CancellationToken cancellationToken)
        => GetWirkstoffGehaltAsync(kennr, wirknr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAdresseAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("adresse/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAdresseByAdresseNrAsync(string adresseNr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("adresse/", new Dictionary<string, string?> { ["adresse_nr"] = adresseNr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAdresseByIdAsync(string adresseNr, CancellationToken cancellationToken)
        => GetAdresseByAdresseNrAsync(adresseNr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAntragAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("antrag/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAntragAsync(string? antragnr, string? antragstellerNr, string? kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("antrag/", new Dictionary<string, string?>
        {
            ["antragnr"] = antragnr,
            ["antragsteller_nr"] = antragstellerNr,
            ["kennr"] = kennr,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAntragByIdAsync(string antragnr, string kennr, CancellationToken cancellationToken)
        => GetAntragAsync(antragnr, null, kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAuflageReduAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("auflage_redu/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAuflageReduByAuflagenrAsync(string auflagenr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("auflage_redu/", new Dictionary<string, string?> { ["auflagenr"] = auflagenr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAuflageReduByIdAsync(string auflagenr, CancellationToken cancellationToken)
        => GetAuflageReduByAuflagenrAsync(auflagenr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAuflagenAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("auflagen/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAuflagenAsync(string? auflage, string? auflagenr, string? ebene, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("auflagen/", new Dictionary<string, string?>
        {
            ["auflage"] = auflage,
            ["auflagenr"] = auflagenr,
            ["ebene"] = ebene,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAuflagenByIdAsync(string auflage, string auflagenr, string ebene, CancellationToken cancellationToken)
        => GetAuflagenAsync(auflage, auflagenr, ebene, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgAufwandAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_aufwand/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgAufwandByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_aufwand/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgAufwandByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgAufwandByAwgIdAsync(awgId, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgBemAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_bem/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgBemByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_bem/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgBemByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgBemByAwgIdAsync(awgId, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgKulturAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_kultur/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgKulturByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_kultur/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgKulturByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgKulturByAwgIdAsync(awgId, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgPartnerAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_partner/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgPartnerByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_partner/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgPartnerByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgPartnerByAwgIdAsync(awgId, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgPartnerAufwandAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_partner_aufwand/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgPartnerAufwandByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_partner_aufwand/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgPartnerAufwandByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgPartnerAufwandByAwgIdAsync(awgId, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgVerwendungszweckAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_verwendungszweck/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgVerwendungszweckByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_verwendungszweck/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgVerwendungszweckByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgVerwendungszweckByAwgIdAsync(awgId, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgWartezeitAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_wartezeit/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgWartezeitAsync(string? awgId, string? awgWartezeitNr, string? kultur, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_wartezeit/", new Dictionary<string, string?>
        {
            ["awg_id"] = awgId,
            ["awg_wartezeit_nr"] = awgWartezeitNr,
            ["kultur"] = kultur,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgWartezeitByIdAsync(string awgId, string awgWartezeitNr, string kultur, CancellationToken cancellationToken)
        => GetAwgWartezeitAsync(awgId, awgWartezeitNr, kultur, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgWartezeitAusgKulturAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_wartezeit_ausg_kultur/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgWartezeitAusgKulturAsync(string? awgWartezeitNr, string? kultur, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_wartezeit_ausg_kultur/", new Dictionary<string, string?>
        {
            ["awg_wartezeit_nr"] = awgWartezeitNr,
            ["kultur"] = kultur,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgWartezeitAusgKulturByIdAsync(string awgWartezeitNr, string kultur, CancellationToken cancellationToken)
        => GetAwgWartezeitAusgKulturAsync(awgWartezeitNr, kultur, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgZeitpunktAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_zeitpunkt/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgZeitpunktByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_zeitpunkt/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgZeitpunktByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgZeitpunktByAwgIdAsync(awgId, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllAwgZulassungAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_zulassung/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgZulassungByAwgIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("awg_zulassung/", new Dictionary<string, string?> { ["awg_id"] = awgId }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAwgZulassungByIdAsync(string awgId, CancellationToken cancellationToken)
        => GetAwgZulassungByAwgIdAsync(awgId, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllGhsGefahrenhinweiseAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("ghs_gefahrenhinweise/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetGhsGefahrenhinweiseByKennrAsync(string kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("ghs_gefahrenhinweise/", new Dictionary<string, string?> { ["kennr"] = kennr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetGhsGefahrenhinweiseByIdAsync(string kennr, CancellationToken cancellationToken)
        => GetGhsGefahrenhinweiseByKennrAsync(kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllGhsGefahrensymboleAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("ghs_gefahrensymbole/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetGhsGefahrensymboleByKennrAsync(string kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("ghs_gefahrensymbole/", new Dictionary<string, string?> { ["kennr"] = kennr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetGhsGefahrensymboleByIdAsync(string kennr, CancellationToken cancellationToken)
        => GetGhsGefahrensymboleByKennrAsync(kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllGhsSicherheitshinweiseAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("ghs_sicherheitshinweise/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetGhsSicherheitshinweiseByKennrAsync(string kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("ghs_sicherheitshinweise/", new Dictionary<string, string?> { ["kennr"] = kennr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetGhsSicherheitshinweiseByIdAsync(string kennr, CancellationToken cancellationToken)
        => GetGhsSicherheitshinweiseByKennrAsync(kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllGhsSignalwoerterAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("ghs_signalwoerter/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetGhsSignalwoerterByKennrAsync(string kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("ghs_signalwoerter/", new Dictionary<string, string?> { ["kennr"] = kennr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetGhsSignalwoerterByIdAsync(string kennr, CancellationToken cancellationToken)
        => GetGhsSignalwoerterByKennrAsync(kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllHinweisAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("hinweis/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetHinweisByEbeneAsync(string ebene, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("hinweis/", new Dictionary<string, string?> { ["ebene"] = ebene }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetHinweisByIdAsync(string ebene, CancellationToken cancellationToken)
        => GetHinweisByEbeneAsync(ebene, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllKodelisteAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("kodeliste/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetKodelisteByKodelisteAsync(string kodeliste, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("kodeliste/", new Dictionary<string, string?> { ["kodeliste"] = kodeliste }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetKodelisteByIdAsync(string kodeliste, CancellationToken cancellationToken)
        => GetKodelisteByKodelisteAsync(kodeliste, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllKulturGruppeAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("kultur_gruppe/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetKulturGruppeAsync(string? kultur, string? kulturGruppe, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("kultur_gruppe/", new Dictionary<string, string?>
        {
            ["kultur"] = kultur,
            ["kultur_gruppe"] = kulturGruppe,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetKulturGruppeByIdAsync(string kultur, string kulturGruppe, CancellationToken cancellationToken)
        => GetKulturGruppeAsync(kultur, kulturGruppe, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllMittelAbgelaufenAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_abgelaufen/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelAbgelaufenByKennrAsync(string kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_abgelaufen/", new Dictionary<string, string?> { ["kennr"] = kennr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelAbgelaufenByIdAsync(string kennr, CancellationToken cancellationToken)
        => GetMittelAbgelaufenByKennrAsync(kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllMittelAbpackungAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_abpackung/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelAbpackungByKennrAsync(string kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_abpackung/", new Dictionary<string, string?> { ["kennr"] = kennr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelAbpackungByIdAsync(string kennr, CancellationToken cancellationToken)
        => GetMittelAbpackungByKennrAsync(kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllMittelGefahrenSymbolAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_gefahren_symbol/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelGefahrenSymbolByKennrAsync(string kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_gefahren_symbol/", new Dictionary<string, string?> { ["kennr"] = kennr }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelGefahrenSymbolByIdAsync(string kennr, CancellationToken cancellationToken)
        => GetMittelGefahrenSymbolByKennrAsync(kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllMittelVertriebAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_vertrieb/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelVertriebAsync(string? kennr, string? vertriebsfirmaNr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_vertrieb/", new Dictionary<string, string?>
        {
            ["kennr"] = kennr,
            ["vertriebsfirma_nr"] = vertriebsfirmaNr,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelVertriebByIdAsync(string kennr, string vertriebsfirmaNr, CancellationToken cancellationToken)
        => GetMittelVertriebAsync(kennr, vertriebsfirmaNr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllMittelWirkbereichAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_wirkbereich/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelWirkbereichAsync(string? kennr, string? wirkungsbereich, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("mittel_wirkbereich/", new Dictionary<string, string?>
        {
            ["kennr"] = kennr,
            ["wirkungsbereich"] = wirkungsbereich,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetMittelWirkbereichByIdAsync(string kennr, string wirkungsbereich, CancellationToken cancellationToken)
        => GetMittelWirkbereichAsync(kennr, wirkungsbereich, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllParallelimportAbgelaufenAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("parallelimport_abgelaufen/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetParallelimportAbgelaufenAsync(string? importeurNr, string? piReferenzKennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("parallelimport_abgelaufen/", new Dictionary<string, string?>
        {
            ["importeur_nr"] = importeurNr,
            ["pi_referenz_kennr"] = piReferenzKennr,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetParallelimportAbgelaufenByIdAsync(string importeurNr, string piReferenzKennr, CancellationToken cancellationToken)
        => GetParallelimportAbgelaufenAsync(importeurNr, piReferenzKennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllParallelimportGueltigAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("parallelimport_gueltig/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetParallelimportGueltigAsync(string? importeurNr, string? piReferenzKennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("parallelimport_gueltig/", new Dictionary<string, string?>
        {
            ["importeur_nr"] = importeurNr,
            ["pi_referenz_kennr"] = piReferenzKennr,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetParallelimportGueltigByIdAsync(string importeurNr, string piReferenzKennr, CancellationToken cancellationToken)
        => GetParallelimportGueltigAsync(importeurNr, piReferenzKennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllSchadorgGruppeAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("schadorg_gruppe/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetSchadorgGruppeAsync(string? schadorg, string? schadorgGruppe, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("schadorg_gruppe/", new Dictionary<string, string?>
        {
            ["schadorg"] = schadorg,
            ["schadorg_gruppe"] = schadorgGruppe,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetSchadorgGruppeByIdAsync(string schadorg, string schadorgGruppe, CancellationToken cancellationToken)
        => GetSchadorgGruppeAsync(schadorg, schadorgGruppe, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllStaerkungAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("staerkung/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetStaerkungAsync(string? antragstellerNr, string? kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("staerkung/", new Dictionary<string, string?>
        {
            ["antragsteller_nr"] = antragstellerNr,
            ["kennr"] = kennr,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetStaerkungByIdAsync(string antragstellerNr, string kennr, CancellationToken cancellationToken)
        => GetStaerkungAsync(antragstellerNr, kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllStaerkungVertriebAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("staerkung_vertrieb/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetStaerkungVertriebAsync(string? kennr, string? vertriebsfirmaNr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("staerkung_vertrieb/", new Dictionary<string, string?>
        {
            ["kennr"] = kennr,
            ["vertriebsfirma_nr"] = vertriebsfirmaNr,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetStaerkungVertriebByIdAsync(string kennr, string vertriebsfirmaNr, CancellationToken cancellationToken)
        => GetStaerkungVertriebAsync(kennr, vertriebsfirmaNr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllStandAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("stand/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllZusatzstoffAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("zusatzstoff/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetZusatzstoffAsync(string? antragstellerNr, string? kennr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("zusatzstoff/", new Dictionary<string, string?>
        {
            ["antragsteller_nr"] = antragstellerNr,
            ["kennr"] = kennr,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetZusatzstoffByIdAsync(string antragstellerNr, string kennr, CancellationToken cancellationToken)
        => GetZusatzstoffAsync(antragstellerNr, kennr, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetAllZusatzstoffVertriebAsync(CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("zusatzstoff_vertrieb/", null, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetZusatzstoffVertriebAsync(string? kennr, string? vertriebsfirmaNr, CancellationToken cancellationToken)
        => GetAllAsync<JsonElement>("zusatzstoff_vertrieb/", new Dictionary<string, string?>
        {
            ["kennr"] = kennr,
            ["vertriebsfirma_nr"] = vertriebsfirmaNr,
        }, cancellationToken);

    public Task<IReadOnlyList<JsonElement>> GetZusatzstoffVertriebByIdAsync(string kennr, string vertriebsfirmaNr, CancellationToken cancellationToken)
        => GetZusatzstoffVertriebAsync(kennr, vertriebsfirmaNr, cancellationToken);

    private async Task<IReadOnlyList<T>> GetAllAsync<T>(string path, Dictionary<string, string?>? query, CancellationToken cancellationToken)
    {
        var client = CreateClient();
        var relativeUrl = AppendQuery(path, query);
        return await OrdsClient.GetAllAsync<T>(client, relativeUrl, options.Value, cancellationToken);
    }

    private async Task<string?> LoadKodeTextAsync(string kode, CancellationToken cancellationToken)
    {
        var result = await GetKodeAsync(kode, null, _languageCode, cancellationToken);
        if (result.Count == 0)
        {
            result = await GetKodeAsync(kode, null, null, cancellationToken);
        }

        var match = result.FirstOrDefault(item => string.Equals(item.Sprache, _languageCode, StringComparison.OrdinalIgnoreCase));
        return match?.KodeText ?? result.FirstOrDefault()?.KodeText;
    }

    private async Task<List<SchadorgInfo>> DecodeSchadorgAsync(
        IEnumerable<string> codes,
        CancellationToken cancellationToken)
    {
        var list = new List<SchadorgInfo>();
        foreach (var code in codes.OrderBy(code => code, StringComparer.OrdinalIgnoreCase))
        {
            var text = await DeKodeAsync(code, cancellationToken);
            list.Add(new SchadorgInfo
            {
                Kode = code,
                Text = text
            });
        }

        return list;
    }

    private static string ResolveWirkstoffName(
        IReadOnlyDictionary<string, string> lookup,
        WirkstoffGehaltDto item)
    {
        if (!string.IsNullOrWhiteSpace(item.WirkNr) && lookup.TryGetValue(item.WirkNr, out var name))
        {
            return name;
        }

        return item.WirkNr ?? "Unbekannt";
    }

    private static string? ResolveWirkstoffGehalt(WirkstoffGehaltDto item)
    {
        if (item.GehaltReinGrundstruktur.HasValue)
        {
            return item.GehaltReinGrundstruktur.Value.ToString("0.####", System.Globalization.CultureInfo.InvariantCulture);
        }

        if (item.GehaltRein.HasValue)
        {
            return item.GehaltRein.Value.ToString("0.####", System.Globalization.CultureInfo.InvariantCulture);
        }

        return null;
    }

    private static string? ResolveMittelName(MittelDto mittel)
    {
        if (!string.IsNullOrWhiteSpace(mittel.Mittelname))
        {
            return mittel.Mittelname;
        }

        return GetExtensionValue(mittel, "bezeichnung", "name", "mittel_name", "mittel");
    }

    private static string? ResolveMittelZulassungVon(MittelDto mittel)
        => mittel.ZulassungVon ?? GetExtensionValue(mittel, "zul_von", "zulassung_von_dt", "zulassung_beginn");

    private static string? ResolveMittelZulassungBis(MittelDto mittel)
        => mittel.ZulassungBis ?? GetExtensionValue(mittel, "zul_bis", "zulassung_bis_dt", "zulassung_ende");

    private static string? GetExtensionValue(MittelDto mittel, params string[] keys)
    {
        if (mittel.ExtensionData is null)
        {
            return null;
        }

        foreach (var key in keys)
        {
            if (mittel.ExtensionData.TryGetValue(key, out var value) && value.ValueKind != System.Text.Json.JsonValueKind.Null)
            {
                return value.ToString();
            }
        }

        foreach (var key in keys)
        {
            var match = mittel.ExtensionData.FirstOrDefault(pair =>
                pair.Key.Equals(key, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(match.Key) && match.Value.ValueKind != System.Text.Json.JsonValueKind.Null)
            {
                return match.Value.ToString();
            }
        }

        return null;
    }

    private static DateOnly? ParseDate(string? raw)
    {
        if (string.IsNullOrWhiteSpace(raw))
        {
            return null;
        }

        var trimmed = raw.Trim();
        var formats = new[]
        {
            "yyyy-MM-dd",
            "yyyy-MM-ddTHH:mm:ss",
            "yyyy-MM-ddTHH:mm:ssZ",
            "yyyy-MM-ddTHH:mm:ss.fffZ",
            "dd.MM.yyyy",
            "yyyyMMdd"
        };

        if (DateTime.TryParseExact(trimmed, formats, System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.AssumeUniversal, out var exactParsed))
        {
            return DateOnly.FromDateTime(exactParsed);
        }

        if (DateTime.TryParseExact(trimmed, formats, System.Globalization.CultureInfo.GetCultureInfo("de-DE"),
                System.Globalization.DateTimeStyles.AssumeLocal, out exactParsed))
        {
            return DateOnly.FromDateTime(exactParsed);
        }

        if (DateTime.TryParse(trimmed, out var parsed))
        {
            return DateOnly.FromDateTime(parsed);
        }

        return null;
    }

    private static async Task<T> AwaitWithCancellationAsync<T>(Task<T> task, CancellationToken cancellationToken)
    {
        if (!cancellationToken.CanBeCanceled)
        {
            return await task;
        }

        var tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        await using var _ = cancellationToken.Register(
            static state => ((TaskCompletionSource<bool>)state!).TrySetResult(true),
            tcs);

        if (task != await Task.WhenAny(task, tcs.Task))
        {
            throw new OperationCanceledException(cancellationToken);
        }

        return await task;
    }

    private static string AppendQuery(string path, Dictionary<string, string?>? query)
    {
        if (query is null || query.Count == 0)
        {
            return path;
        }

        var parts = query
            .Where(pair => !string.IsNullOrWhiteSpace(pair.Value))
            .Select(pair => $"{pair.Key}={WebUtility.UrlEncode(pair.Value)}")
            .ToList();

        if (parts.Count == 0)
        {
            return path;
        }

        return path + "?" + string.Join("&", parts);
    }
}
