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
    public partial class tip : Form
    {
        public tip()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Inputs from form
            string empName = txtEmpName.Text; // Employee name from search textbox
            DateTime bdate = dateTimePickerStart.Value; // Start date
            DateTime lastDate = dateTimePickerEnd.Value; // End date

            // SQL connection
            SqlConnection conn = authentication.connect();
            try
            {
                conn.Open();

                // SQL query to call the UDF
                string query = "SELECT dbo.CalculateEmployeeTips(@empName, @startDate, @endDate) AS TotalTips;";

                // Create SQL Command
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@empName", empName);
                cmd.Parameters.AddWithValue("@startDate", bdate);
                cmd.Parameters.AddWithValue("@endDate", lastDate);

                // Execute command
                object result = cmd.ExecuteScalar();
                decimal totalTips = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                // Display result in a label or textbox
                txtTotalTips.Text = $"Total Tips: {totalTips:C2}";
                lblsal.Text = $"Total Salary: {Convert.ToDecimal(textBox1.Text)+totalTips}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtTotalTips_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            d.Show();
            this.Close();
        }
    }
}
