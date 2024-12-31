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
            SqlConnection conn = authentication.connect();
            String query = "SELECT * FROM [bill] WHERE date=CAST(GETDATE() AS DATE)";
            double tot = 0;
            double prof = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
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
            }finally
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

        private void btnsrch_Click(object sender, EventArgs e)
        {
            String datef = dateTimePicker2.Text;
            String datet = dateTimePicker1.Text;
            //String query = $"SELECT * FROM [bill] WHERE date BETWEEN '{datef}' AND '{datet}'";
            //String query = "SELECT * FROM bill WHERE date BETWEEN '2024-12-25' AND '2024-12-26'";
            String query = $"select b.bid AS Bill_No,b.emp AS Cashier,b.total AS Total,b.profit AS Profit,b.date AS Date,d.code AS Discount from bill AS b INNER JOIN discount AS d ON disid=id WHERE date BETWEEN '{datef}' AND '{datet}'";
            SqlConnection conn = authentication.connect();
            double t = 0;
            double p = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t += Convert.ToDouble(reader["total"]); 
                    p += Convert.ToDouble(reader["profit"]);
                }

                lblincnew.Text = $"Income: {Convert.ToString(t)}";
                lblprofnew.Text = $"Profit: {Convert.ToString(p)}";

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            {
                conn.Close();
            }
            
            
            


        }
    }
}
