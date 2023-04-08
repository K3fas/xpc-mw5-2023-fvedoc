using AutoMapper.Internal;
using FVEDoc.Api.BLL.Installers;
using FVEDoc.Api.DAL.Common.Entities;
using FVEDoc.Api.DAL.Mock;
using FVEDoc.Api.DAL.Mock.Installers;
using FVEDoc.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


ConfigureAutoMapper(builder.Services);
ConfigureDependencies(builder.Services, builder.Configuration);

var app = builder.Build();

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