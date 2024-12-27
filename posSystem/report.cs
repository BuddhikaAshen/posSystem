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
            MySqlConnection conn = authentication.connect();
            String query = "SELECT * FROM bill WHERE date=CURDATE()";
            double tot = 0;
            double prof = 0;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tot += reader.GetDouble("total");
                    prof += reader.GetDouble("profit");
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
            String query = $"SELECT * FROM bill WHERE date BETWEEN '{datef}' AND '{datet}'";
            //String query = "SELECT * FROM bill WHERE date BETWEEN '2024-12-25' AND '2024-12-26'";
            MySqlConnection conn = authentication.connect();
            double t = 0;
            double p = 0;
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    t += reader.GetDouble("total");
                    p += reader.GetDouble("profit");
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
