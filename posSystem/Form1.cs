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
using MySql.Data.MySqlClient;


namespace posSystem
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            String name = uname.Text;
            String pass = password.Text;
            String role = "";

            String connString = "server=127.0.0.1; user=root; database=pos; password=";
            MySqlConnection conn = new MySqlConnection(connString);

            String query = $"SELECT * FROM user WHERE name='{name}' AND password='{pass}'";
            
            
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows && reader.Read())
                {
                    role = reader.GetString("role");
                    
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);             
            }
            finally
            {
            conn.Close(); 
            }




        }
    }
}
