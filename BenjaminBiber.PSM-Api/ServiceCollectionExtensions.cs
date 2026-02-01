using BenjaminBiber.PSM_Api.Data.Clients;
using BenjaminBiber.PSM_Api.Data.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BenjaminBiber.PSM_Api;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPsmApiClients(
        this IServiceCollection services,
        Action<PsmApiOptions>? configure = null)
    {
        if (configure is null)
        {
            services.Configure<PsmApiOptions>(_ => { });
        }
        else
        {
            services.Configure(configure);
        }
        services.AddHttpClient("PsmApi", (sp, client) =>
        {
            var options = sp.GetRequiredService<IOptions<PsmApiOptions>>().Value;
            client.BaseAddress = new Uri(options.BaseUrl);
        });
        services.AddSingleton<IPsmApiClient, PsmApiClient>();

        return services;
    }
}
