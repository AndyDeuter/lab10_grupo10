using MySql.Data.MySqlClient;
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
            connectionString = $"Data Source=ANDYSQLEXPRESS01;Initial Catalog=EcommerceDB;Integrated Security=True;Encrypt=False";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }

}
