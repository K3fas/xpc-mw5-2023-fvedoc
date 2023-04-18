using AutoMapper;
using FVEDoc.Api.BLL.Installers;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Mock.Installers;
using FVEDoc.Common.Extensions;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.ResolveConflictingActions(apiDescriptions =>
    {
        int best_order = int.MaxValue;
        ApiDescription? best_descr = null;
        foreach (var curr_descr in apiDescriptions)
        {
            int curr_order = curr_descr.ActionDescriptor.AttributeRouteInfo?.Order ?? 0;
            if (curr_order < best_order)
            {
                best_descr = curr_descr;
                best_order = curr_order;
            }
        }
        return best_descr;
    });
});


ConfigureAutoMapper(builder.Services);
ConfigureDependencies(builder.Services, builder.Configuration);

var app = builder.Build();

ValidateAutomapper(app.Services);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void ConfigureDependencies(IServiceCollection services, ConfigurationManager configuration)
{
    services.AddInstaller<ApiDALMockInstaller>();
    services.AddInstaller<ApiBLLInstaller>();
}

void ConfigureAutoMapper(IServiceCollection services)
{
    //services.AddAutoMapper(cfg => { }, typeof(EntityBase), typeof(ApiBLLInstaller));
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
