using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_DesignADatabaseCommand
{
    public class SqlConnection : DbConnection
    {
        public string ConnectionString { get; set; }

        public SqlConnection(string connectionString)
            : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override void Open()
        {
            Console.WriteLine($"Open SQL connection: {ConnectionString}");
        }

        public override void Close()
        {
            Console.WriteLine($"Close SQL connection: {ConnectionString}");
        }
    }
}
