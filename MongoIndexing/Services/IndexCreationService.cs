using MongoCollections.Generics;
using MongoConnection.Interfaces;
using MongoDB.Driver;
using MongoIndexing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoIndexing.Services
{
    public class IndexCreationService
    {
        private readonly IMongoDbConnectionSettingsProvider _dbConnectionSettingsProvider;

        public IndexCreationService(IMongoDbConnectionSettingsProvider dbConnectionSettingsProvider)
        {
            this._dbConnectionSettingsProvider = dbConnectionSettingsProvider;
        }

        public async Task<string> CreateIndexAsync()
        {
            CreateIndexMondoDB<Person> indexMondoDB = new CreateIndexMondoDB<Person>(new MongoCollection<Person>(this._dbConnectionSettingsProvider));

            FieldDefinition<Person> fieldDefinition = "Name";

            return await indexMondoDB.CreateIndexAsync(fieldDefinition);
        }
    }
}
