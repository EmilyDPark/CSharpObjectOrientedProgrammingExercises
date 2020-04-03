using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_DesignADatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("abcde");
            sqlConnection.Open();
            sqlConnection.Close();

            Console.WriteLine();

            var oracleConnection = new OracleConnection("fghij");
            oracleConnection.Open();
            oracleConnection.Close();
        }
    }
}
