using FVEDoc.Api.DAL.Common.Repositories;
using FVEDoc.Api.DAL.Mongo.Serializers;
using FVEDoc.Common.Installers;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace FVEDoc.Api.DAL.Mongo.Installers;
public class ApiDALMongoInstaller : IInstaller
{
    static bool guidSetup = false;
    public void Install(IServiceCollection serviceCollection)
    {
        // Mongo
        if (guidSetup is false)
        {
            BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;
            BsonDefaults.GuidRepresentationMode = GuidRepresentationMode.V3;
            BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));     // needs to be initialized before MongoDB
            BsonSerializer.RegisterSerializer(new SizeSerializer());
            BsonSerializer.RegisterSerializer(new UnitTypeSerializer());
            guidSetup = true;
        }

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

    }
}

