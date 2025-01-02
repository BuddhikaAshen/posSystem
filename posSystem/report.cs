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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            load();
            SqlConnection conn = authentication.connect();
            String query = "SELECT * FROM [bill] WHERE date=CAST(GETDATE() AS DATE)";
            double tot = 0;
            double prof = 0;
            try
            {
                conn.Open();
                // Use the stored procedure instead of a raw query
                SqlCommand cmd = new SqlCommand("GetTodaysBills", conn)
                {
                    CommandType = CommandType.StoredProcedure // Specify it's a stored procedure
                };

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tot += Convert.ToDouble(reader["total"]);
                    prof += Convert.ToDouble(reader["profit"]);
                }

                lbloutinc.Text = $"Today income : Rs.{Convert.ToString(tot)}";
                lbloutprof.Text = $"Today profit : Rs.{Convert.ToString(prof)}";
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
            dashboard d = new dashboard();
            this.Close();
            d.Show();
        }
        private void load()
        {
            SqlConnection conn = authentication.connect();
            String query = $"SELECT * FROM vw_PaymentDetails";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;

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
            String datef = dateTimePicker2.Text;
            String datet = dateTimePicker1.Text;

            SqlConnection conn = authentication.connect();
            double t = 0;
            double p = 0;

            try
            {
                conn.Open();

                // Define the query to call the UDF
                String query = $@"
            SELECT * 
            FROM dbo.GetBillDetailsAndTotal(@startDate, @endDate);";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@startDate", datef);
                cmd.Parameters.AddWithValue("@endDate", datet);

                // Use SqlDataAdapter to fill the DataGridView
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Calculate the totals using SqlDataReader
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t += Convert.ToDouble(reader["Total"]);
                    p += Convert.ToDouble(reader["Profit"]);
                }

                lblincnew.Text = $"Income: {t}";
                lblprofnew.Text = $"Profit: {p}";
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
