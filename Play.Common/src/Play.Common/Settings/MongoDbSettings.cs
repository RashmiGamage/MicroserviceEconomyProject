namespace Play.Common.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; init; }
        public int Port { get; init; }
        // we use init because we are not planning to change thses setting after the microservices are loaded.
        //therefore anybody cannot change these values after they have been initialized.

        public string ConnectionString => $"mongodb://{Host}:{Port}"; // expression body definition
    }
}