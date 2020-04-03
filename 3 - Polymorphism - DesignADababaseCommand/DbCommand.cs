using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_DesignADatabaseCommand
{
    public class DbCommand
    {
        private string Command { get; set; }
        private DbConnection Connection { get; set; }

        public DbCommand(string command, DbConnection connection)
        {
            if (string.IsNullOrEmpty(command))
                throw new InvalidOperationException("Command cannot be null or empty.");

            Command = command;
            Connection = connection;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine("Execute: " + Command);
            Connection.Close();
        }
    }
}
