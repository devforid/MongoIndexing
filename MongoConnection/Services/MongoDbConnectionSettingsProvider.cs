using MongoConnection.Interfaces;
using MongoConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoConnection.Services
{
    public class MongoDbConnectionSettingsProvider: IMongoDbConnectionSettingsProvider
    {
        public MongoDbConnectionSettingsProvider()
        {

        }

        public DatabaseConnection GetDatabaseConnection(string? tenantId = null)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection()
            {
                ConnectionString = "mongodb://localhost:27017"
            };

            return databaseConnection;
        }
    }
}
