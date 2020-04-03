using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_DesignADatabaseConnection
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        private TimeSpan _timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string cannot be null or empty");

            _connectionString = connectionString;
        }
        public abstract void Open();

        public abstract void Close();
    }
}
