using MongoConnection.Interfaces;
using MongoDB.Driver;
using MongoIndexing.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCollections.Generics
{
    public class MongoCollection<T>
    {
        private readonly IMongoDbConnectionSettingsProvider _mongoDbConnectionSettingsProvider;
        public MongoCollection(IMongoDbConnectionSettingsProvider mongoDbConnectionSettingsProvider)
        {
            this._mongoDbConnectionSettingsProvider = mongoDbConnectionSettingsProvider;
        }

        public IMongoCollection<T> GetIMongoCollections()
        {
            var databaseConnectionSettings = _mongoDbConnectionSettingsProvider.GetDatabaseConnection();

            var db = new MongoClient(databaseConnectionSettings.ConnectionString).GetDatabase(Config.TenantId.ToString().ToUpper());

            var collection = db.GetCollection<T>(typeof(T).Name + 's');

            return collection;
        }
    }
}
