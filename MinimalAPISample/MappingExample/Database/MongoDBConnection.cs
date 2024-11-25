using MinimalAPISample.MappingExample.Config;

namespace MinimalAPISample.MappingExample.Database;
using MongoDB.Driver;

public class MongoDBConnection
{
    private readonly IMongoDatabase _database;
    private readonly IMongoClient _client;
    private readonly DotEnv _env;

    public MongoDBConnection()
    {
        _env = new DotEnv();
        _client = new MongoClient(_env.MongoUri);
        _database = _client.GetDatabase(_env.DbName);
    }
    
    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return _database.GetCollection<T>(collectionName);
    }
}