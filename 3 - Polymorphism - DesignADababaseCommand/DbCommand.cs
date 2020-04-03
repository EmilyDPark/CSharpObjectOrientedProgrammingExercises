using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_DesignADatabaseCommand
{
    public class DbCommand
    {
        private string _command { get; set; }
        private DbConnection _connection { get; set; }

        public DbCommand(string command, DbConnection connection)
        {
            if (string.IsNullOrEmpty(command))
                throw new InvalidOperationException("Command cannot be null or empty.");

            _command = command;
            _connection = connection;
        }

        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Execute: " + _command);
            _connection.Close();
        }
    }
}
