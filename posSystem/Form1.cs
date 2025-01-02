using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace posSystem
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        public static class DatabaseHelper
        {
            public static bool ValidateUser(string username, string password, out string role)
            {
                role = "";
                string connString = "Data Source=(local);Initial Catalog=posdb;Integrated Security=True;Encrypt=False";
                string query = $"SELECT * FROM [user] WHERE name=@username AND password=@password";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows && reader.Read())
                                {
                                    role = reader["role"].ToString();
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return false;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String name = uname.Text;
            String pass = password.Text;
            String role;

            if (DatabaseHelper.ValidateUser(name, pass, out role))
            {
                authentication.IsLoggedIn = true;
                authentication.UserRole = role;
                authentication.UserName = name;

                dashboard d = new dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User Doesnt Exist");
            }
        }

    }
}
