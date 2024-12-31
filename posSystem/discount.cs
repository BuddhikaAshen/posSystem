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
using static System.Net.WebRequestMethods;
using System.Xml.Linq;
using Org.BouncyCastle.Ocsp;

namespace posSystem
{
    public partial class discount : Form
    {
        public discount()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = authentication.connect();
            String query = $"insert into [discount](code,per) values('{txtaddcode.Text}','{Convert.ToDouble(txtaddper.Text)/100.0}')";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    MessageBox.Show("Discount registered successfully");
                    txtaddcode.Text = "";
                    txtaddper.Text = "";
                    txtaddcode.Focus();
                    loaddata();



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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = authentication.connect();
            String query = $"update [discount] set per={Convert.ToDouble(txtupper.Text) / 100.0} where code='{txtupcode.Text}'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    MessageBox.Show("Updated");
                    txtupper.Text = "";
                    txtupcode.Text = "";
                    txtupcode.Focus();
                    loaddata();



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

        private void btnback_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }

        private void loaddata()
        {
            SqlConnection conn = authentication.connect();
            String query = "SELECT * FROM [discount]";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

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

        private void discount_Load(object sender, EventArgs e)
        {
            loaddata();
            if (authentication.UserRole != "admin")
            {
                button3.Visible = false;
                button2.Visible = false;
                


            }
        }
    }
}
