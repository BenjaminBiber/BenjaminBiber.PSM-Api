using BenjaminBiber.BVL_PSM_Client;
using BenjaminBiber.BVL_PSM_Client.Data.Options;
using BenjaminBiber.BVL_PSM_Client.Data.Services;
using Microsoft.Extensions.Configuration;
using BenjaminBiber.PSM_Api.TestApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMemoryCache();
builder.Services.AddSingleton<ExportColumnRegistry>();
builder.Services.AddSingleton<CsvBuilder>();
builder.Services.AddScoped<IPsmExportService, PsmExportService>();
builder.Services.AddPsmApiClients(options =>
    builder.Configuration.GetSection("PsmApi").Bind(options));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found");
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
