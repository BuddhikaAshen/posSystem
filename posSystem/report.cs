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
    }
}
