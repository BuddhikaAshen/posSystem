using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace posSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            String uname = txtuname.Text;
            String pass = txtpass.Text;

            string connString = "Data Source=(local);Initial Catalog=pos;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                String query = $"INSERT INTO [user](name,password,role) VALUES('{uname}','{pass}','user')";
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r == 1) MessageBox.Show("User registered Successfully");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                conn.Close();
            }


           


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Hide();
        }
    }
}
