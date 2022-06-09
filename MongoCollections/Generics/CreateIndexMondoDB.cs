using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoCollections.Generics
{
    public class CreateIndexMondoDB<T>
    {
        private readonly MongoCollection<T> _mongoCollection;
        public CreateIndexMondoDB(MongoCollection<T> mongoCollection)
        {
            this._mongoCollection = mongoCollection;
        }
        public async Task<string> CreateTextIndexAsync(FieldDefinition<T> fieldDefinition)
        {
            IMongoCollection<T> mongoCollection = _mongoCollection.GetIMongoCollections();

            var indexKeysDefinition = Builders<T>.IndexKeys.Text(fieldDefinition);

            return await mongoCollection.Indexes.CreateOneAsync(new CreateIndexModel<T>(indexKeysDefinition));
        }
        public async Task<string> CreateIndexAsync(FieldDefinition<T> fieldDefinition)
        {
            IMongoCollection<T> mongoCollection = _mongoCollection.GetIMongoCollections();

            var indexKeysDefinition = Builders<T>.IndexKeys.Ascending(fieldDefinition);

            return await mongoCollection.Indexes.CreateOneAsync(new CreateIndexModel<T>(indexKeysDefinition));
        }
        public async Task<string> CreateGeo2DSphereIndexAsync(FieldDefinition<T> fieldDefinition)
        {
            IMongoCollection<T> mongoCollection = _mongoCollection.GetIMongoCollections();

            var indexKeysDefinition = Builders<T>.IndexKeys.Geo2DSphere(fieldDefinition);

            return await mongoCollection.Indexes.CreateOneAsync(new CreateIndexModel<T>(indexKeysDefinition));
        }

    }
}
