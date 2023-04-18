using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace FVEDoc.Api.DAL.Mongo;
public class MongoDbContext
{
    private readonly MongoClient _client;
    private readonly IMongoDatabase _database;
    public MongoDbContext(IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MongoDB");
        _client = new MongoClient(connectionString);

        var databaseName = configuration.GetValue<string>("DatabaseName");
        _database = _client.GetDatabase(databaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return _database.GetCollection<T>(collectionName);
    }
}

