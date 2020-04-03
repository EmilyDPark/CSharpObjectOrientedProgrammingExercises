using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_DesignADatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        public string _connectionString { get; set; }

        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            _connectionString = connectionString;
        }

        public override void Open()
        {
            Console.WriteLine($"Open SQL connection: {_connectionString}");
        }

        public override void Close()
        {
            Console.WriteLine($"Close SQL connection: {_connectionString}");
        }
    }
}
