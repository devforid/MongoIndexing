using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoConnection.Models
{
    public class DatabaseConnection
    {
        public string? ConnectionString{ get; set;}
        public string? DatabaseName { get; set; }
        public string? TenantId { get; set; }
    }
}
