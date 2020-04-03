using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_DesignADatabaseCommand
{
    public class OracleConnection : DbConnection
    {
        public string ConnectionString { get; set; }

        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override void Open()
        {
            Console.WriteLine($"Open Oracle connection: {ConnectionString}");
        }

        public override void Close()
        {
            Console.WriteLine($"Close Oracle connection: {ConnectionString}");
        }
    }
}
