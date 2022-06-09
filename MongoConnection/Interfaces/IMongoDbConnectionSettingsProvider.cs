using MongoConnection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoConnection.Interfaces
{
    public interface IMongoDbConnectionSettingsProvider
    {
        DatabaseConnection GetDatabaseConnection(string? tenantId = null);
    }
}
