using AutoMapper;
using FVEDoc.Api.BLL.Installers;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Mongo.Installers;
using FVEDoc.Common.Extensions;
using FVEDoc.Web.App;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Create config
// TODO: Fix
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false)
    .AddUserSecrets<Program>()
    .Build();



builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

ConfigureAutoMapper(builder.Services);
ConfigureDependencies(builder.Services, builder.Configuration);

var app = builder.Build();

ValidateAutomapper(app.Services);

await app.RunAsync();

void ConfigureDependencies(IServiceCollection services, WebAssemblyHostConfiguration configuration)
{
    //services.AddInstaller<ApiDALMockInstaller>();
    services.AddInstaller<ApiDALMongoInstaller>();
    services.AddInstaller<ApiBLLInstaller>();
}

void ConfigureAutoMapper(IServiceCollection services)
{
    services.AddAutoMapper(typeof(EntityBase), typeof(ApiBLLInstaller));
}

void ValidateAutomapper(IServiceProvider services)
{
    var mapper = services.GetRequiredService<IMapper>();
    try
    {
        mapper.ConfigurationProvider.AssertConfigurationIsValid();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        throw;
    }
}
