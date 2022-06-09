using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoIndexing.Models
{
    public class Person
    {
        [BsonId]
        public string ItemId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
