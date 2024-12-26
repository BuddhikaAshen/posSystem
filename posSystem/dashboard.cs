using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;


namespace posSystem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            lblout.Text = authentication.UserRole;
            if(authentication.UserRole != "admin")
            {
                lblhide.Visible = false;
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            String connString = "server=127.0.0.1; user=root; database=pos; password=";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void reg_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }
        private void item_Click(object sender, EventArgs e)
        {
            Item_Register reg = new Item_Register();
            this.Hide();
            reg.Show();

        }
        private void stock_Click(object sender, EventArgs e)
        {
            stock stock = new stock();
            stock.Show();
            
        }
        private void sale_Click(object sender, EventArgs e)
        {
            sale sale = new sale();
            sale.Show();

        }
        private void profit_Click(object sender, EventArgs e)
        {
            report report = new report();
            report.Show();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
