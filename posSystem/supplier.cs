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

namespace posSystem
{
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            SqlConnection conn = authentication.connect();
            String query = $"insert into [supplier](name,email,address,contact) values('{txtname.Text}','{txtmail.Text}','{txtaddress.Text}','{txtcontact.Text}')";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    MessageBox.Show("customer registered successfully");
                    txtname.Text = "";
                    txtmail.Text = "";
                    txtaddress.Text = "";
                    txtcontact.Text = "";
                    txtname.Focus();
                    cbsup.Items.Clear();
                    loaddropdown();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = authentication.connect();
            String query = $"update [item] set sid= (SELECT id FROM [supplier] WHERE name = '{cbsup.Text}') where code='{txticode.Text}' ";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if(r == 1)
                {
                    MessageBox.Show("Update successfully!");
                    txticode.Text = "";
                    txticode.Focus();
                }
            }catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }finally
            {
                conn.Close();
            }
        }
        public void loaddropdown()
        {
            SqlConnection conn = authentication.connect();

            try
            {
                conn.Open();
                
                String query2 = $"SELECT * FROM [supplier]";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    String sup = reader2["name"].ToString();
                    cbsup.Items.Add(sup);
                    cbcatserch.Items.Add(sup);
                }
                reader2.Close();



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

        private void supplier_Load(object sender, EventArgs e)
        {
            loaddropdown();
            loaddata();
        }

        private void loaddata()
        {
            SqlConnection conn = authentication.connect();
            String query = "SELECT * FROM [supplier]";
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

        private void btnsrch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = authentication.connect();
            String query = $"SELECT i.code AS Item_code, i.name AS Item_name, s.name AS Supplier_name, s.contact AS Contact FROM [item] AS i INNER JOIN [supplier] AS s ON s.id = i.sid WHERE s.name = '{cbcatserch.Text}'";
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

        private void btreset_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
