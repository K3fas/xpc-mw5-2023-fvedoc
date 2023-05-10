using FVEDoc.Web.App;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FVEDoc.Common.Extensions;
using FVEDoc.Web.DAL.Installers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "allcors",
                      policy =>
                      { policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                      });
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMemoryCache();

ConfigureDependencies(builder.Services, builder.Configuration);

var app = builder.Build();

await app.RunAsync();

void ConfigureDependencies(IServiceCollection services, WebAssemblyHostConfiguration configuration)
{
    services.AddInstaller<WebDALInstaller>();
}


