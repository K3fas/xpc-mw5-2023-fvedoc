using FVEDoc.Web.App;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

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

var app = builder.Build();

await app.RunAsync();

void ConfigureDependencies(IServiceCollection services, WebAssemblyHostConfiguration configuration)
{

}


