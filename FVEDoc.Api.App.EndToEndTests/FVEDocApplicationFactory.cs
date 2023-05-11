using FVEDoc.Api.DAL.Mongo.Serializers;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using System.Reflection;

namespace FVEDoc.Api.App.EndToEndTests;
public class FVEDocApplicationFactory : WebApplicationFactory<Program>
{
    protected override IHost CreateHost(IHostBuilder builder)
    {
        builder.ConfigureServices(collecion =>
        {
            var assemblyName = typeof(Program).Assembly.FullName;
            collecion.AddMvc()
                .AddApplicationPart(Assembly.Load(assemblyName));
        });
        return base.CreateHost(builder);
    }
}

