using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posSystem
{
    public static class authentication
    {
        public static bool IsLoggedIn { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; }

        public static MySqlConnection connect()
        {
            String connString = "server=127.0.0.1; user=root; database=pos; password=";
            return new MySqlConnection(connString);
        }
    }

}
