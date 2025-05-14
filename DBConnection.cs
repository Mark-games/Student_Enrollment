using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace edp_enrollment
{
    internal class DBConnection
    {
        private string connectionString = "server=localhost;user id=root;password=444442221;database=university_information_system;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
