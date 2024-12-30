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

            string connString = "Data Source=(local);Initial Catalog=pos;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connString);

            String query = $"SELECT * FROM [user] WHERE name='{name}' AND password='{pass}'";
            
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows && reader.Read())
                {
                    role = reader["role"].ToString();
                    
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
