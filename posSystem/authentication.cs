using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace posSystem
{
    public static class authentication
    {
        public static bool IsLoggedIn { get; set; }
        public static string UserName { get; set; }
        public static string UserRole { get; set; }

        public static SqlConnection connect()
        {
            string connString = "Data Source=(local);Initial Catalog=pos;Integrated Security=True;Encrypt=False";
            return new SqlConnection(connString);
        }
    }

}
