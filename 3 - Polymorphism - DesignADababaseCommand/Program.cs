using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_DesignADatabaseCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection1 = new DbCommand("Add new column", new SqlConnection("abcde"));
            connection1.Execute();

            Console.WriteLine();

            var connection2 = new DbCommand("Add new row", new OracleConnection("fghij"));
            connection2.Execute();
        }
    }
}
