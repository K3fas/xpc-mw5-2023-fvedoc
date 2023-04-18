using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Common.Installers;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Bson;

namespace FVEDoc.Api.DAL.Mongo.Installers;
public class ApiDALMongoInstaller : IInstaller
{
    public void Install(IServiceCollection serviceCollection)
    {
        // Scrutor
        serviceCollection.Scan(selector =>
                selector.FromAssemblyOf<ApiDALMongoInstaller>()
                        .AddClasses(classes => classes.AssignableTo(typeof(IApiRepository<>)))
                            .AsMatchingInterface()
                            .WithTransientLifetime()
                        .AddClasses(classes => classes.AssignableTo<MongoDbContext>())
                            .AsSelf()
                            .WithSingletonLifetime()
        );

        // Mongo
        BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));

    }
}

