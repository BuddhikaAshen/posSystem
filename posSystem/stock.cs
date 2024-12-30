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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace posSystem
{
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void btnsadd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = authentication.connect();
            int iid = Convert.ToInt32(txtsid.Text);
            double cost = Convert.ToDouble(txtscost.Text);
            double ret = Convert.ToDouble(txtsret.Text);
            int qtty = Convert.ToInt32(txtqtty.Text);

            try
            {
                conn.Open();
                String query = $"INSERT INTO stock(iid,cost,retail,qtty) VALUES({iid},{cost},{ret},{qtty})";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                if(r==1)
                {
                    txtsid.Text = "";
                    txtscode.Text = "";
                    txtscost.Text = "";
                    txtsret.Text = "";
                    txtsqtty.Text = "this";
                    txtsname.Text = "";
                    txtqtty.Text = "";
                    MessageBox.Show("Stock Added!");

                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }finally
            {
                conn.Close();
            }
        }

        private void txtscode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if the Enter key was pressed
            {
                //MessageBox.Show("cliked");
                string code = txtscode.Text.Trim(); // Get the entered code
                if (!string.IsNullOrEmpty(code))
                {
                    FetchItemName(code); // Call the method to fetch and display the item name
                }
                else
                {
                    MessageBox.Show("Please enter a code.");
                }
            }
        }

        private void FetchItemName(String c)
        {
            String code = c;
            String q = $"SELECT * FROM item WHERE code='{code}'";
            MySqlConnection conn = authentication.connect();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    
                    //MessageBox.Show(reader.GetString("name"));
                    txtsname.Text = reader.GetString("name");
                    txtsid.Text = Convert.ToString(reader.GetInt32("id"));
                }
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
    }
}
