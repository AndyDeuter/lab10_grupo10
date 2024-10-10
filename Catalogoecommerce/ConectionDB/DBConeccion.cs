using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectionDB
{
    public class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection(string server, string database, string username, string password)
        {
            connectionString = $"Server={server};Database={database};User ID={username};Password={password};";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
