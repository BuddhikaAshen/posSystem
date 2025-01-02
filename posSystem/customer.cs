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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            SqlConnection conn = authentication.connect();
            String query = $"insert into [customer](name,tp) values('{txtname.Text}','{txttp.Text}')";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    MessageBox.Show("customer registered successfully");
                    txtname.Text = "";
                    txttp.Text = "";
                    txtname.Focus();
                    loaddata();

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                conn.Close();
            }


        }

        private void loaddata()
        {
            SqlConnection conn = authentication.connect();
            try
            {
                conn.Open();
                // Use the stored procedure instead of a raw query
                SqlCommand cmd = new SqlCommand("GetAllCustomers", conn)
                {
                    CommandType = CommandType.StoredProcedure // Specify it's a stored procedure
                };

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt; // Bind data to the DataGridView
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

        private void customer_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
            dashboard d = new dashboard();
            d.Show();
            this.Close();
        }
    }
}
