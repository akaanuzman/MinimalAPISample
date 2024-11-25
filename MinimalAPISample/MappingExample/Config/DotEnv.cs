namespace MinimalAPISample.MappingExample.Config;
using DotNetEnv;

public class DotEnv
{
    public string? MongoUri { get; private set; }
    public string? DbName { get; private set; }
    
    public DotEnv()
    {
       // Load environment variables from .env file
       Env.Load();
         MongoUri = Env.GetString(DotEnvKeys.MONGO_URI.ToString());
         DbName = Env.GetString(DotEnvKeys.DB_NAME.ToString());
    }
}