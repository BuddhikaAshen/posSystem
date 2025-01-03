using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace posSystem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            lblout.Text = $"Username: {authentication.UserName}\n\nRole: {authentication.UserRole}";
            if (authentication.UserRole != "admin")
            {
                reg.Visible = false;
                profit.Visible = false;
                btnsup.Visible = false;
                item.Visible = false;
                stock.Visible = false;
                btntip.Visible = false;


            }

        }

        private void check_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(local);Initial Catalog=pos;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connString);
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
            this.Hide();
            stock.Show();
            
        }
        private void sale_Click(object sender, EventArgs e)
        {
            sale sale = new sale();
            this.Hide();
            sale.Show();

        }
        private void profit_Click(object sender, EventArgs e)
        {
            report report = new report();
            this.Hide();
            report.Show();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btlout_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Close();
            login.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer c = new customer();
            c.Show();
            
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            supplier supplier = new supplier();
            this.Hide();
            supplier.Show();
        }

        private void btndis_Click(object sender, EventArgs e)
        {
            discount discount = new discount(); 
            discount.Show();
            this.Hide();

        }

        private void btntip_Click(object sender, EventArgs e)
        {
            tip tip = new tip();
            tip.Show();
            this.Hide();
        }
    }
}
