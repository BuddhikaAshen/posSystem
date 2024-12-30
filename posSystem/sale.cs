using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace posSystem
{
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if the Enter key was pressed
            {
                //MessageBox.Show("cliked");
                string code = txtcode.Text.Trim(); // Get the entered code
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
        //fetch items
        private void FetchItemName(String c)
        {
            String code = c;
            String q = $"SELECT i.name,i.id,s.cost,s.retail FROM item AS i INNER JOIN stock AS s ON i.id=s.iid WHERE (i.code = '{code}' AND s.qtty > 0)";
            MySqlConnection conn = authentication.connect();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(q, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {

                    //MessageBox.Show(reader.GetString("name"));
                    txtname.Text = reader.GetString("name");
                    txtid.Text = Convert.ToString(reader.GetInt32("id"));
                    txtprice.Text = Convert.ToString(reader.GetDouble("retail"));
                    txtcost.Text = Convert.ToString(reader.GetDouble("cost"));
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
        //Start datagrid code
        List<CartItem> cart = new List<CartItem>();



        //End Data grid code
        
        //add to cart function start
        private void addTocart(String code,String name,int qtty,double c,double r,int id)
        {
            cart.Add(new CartItem
            {
                id = id,
                ItemCode = code,
                ItemName = name,
                Quantity = qtty,
                cost = c,
                retail = r                
            }
                );
            UpdateTotalAmount();
            txtcost.Text = "";
            txtprice.Text = "";
            txtname.Text = "";
            txtcode.Text = ""; 
            txtqtty.Text = "";
            txtid.Text = "";
            txtcode.Focus();
            BindCartToGrid();

        }//add to cart function end
        private void BindCartToGrid()
        {
            dataGridView1.DataSource = null; // Reset the DataSource to ensure the grid refreshes
            dataGridView1.DataSource = cart; // Bind the updated list to the DataGridView

            dataGridView1.Columns["id"].HeaderText = "Item ID";
            dataGridView1.Columns["retail"].HeaderText = "Price";
            dataGridView1.Columns["Quantity"].HeaderText = "Quantity";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                // Only keep the necessary columns visible
                if (column.Name != "id" && column.Name != "retail" && column.Name != "Quantity")
                {
                    column.Visible = false; // Hide unnecessary columns
                }
            }
        }

        //add to datagrid function end
        private void UpdateTotalAmount()
        {
            double totalAmount = 0;

            // Sum up the total price of all items in the cart
            foreach (var item in cart)
            {
                totalAmount += item.retail * item.Quantity;
            }

            // Update the label to display the total amount
            lblTotalAmount.Text = $"Total Amount: {totalAmount:C2}"; // Format as currency
        }

        private void txtqtty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string qtty = txtqtty.Text.Trim(); // Get the entered code
                if (!string.IsNullOrEmpty(qtty))
                {
                    int q = Convert.ToInt32(qtty);
                    int id = Convert.ToInt32(txtid.Text);
                    double c = Convert.ToDouble(txtcost.Text);
                    double r = Convert.ToDouble(txtprice.Text);
                    String name = txtname.Text;
                    String code = txtcode.Text;

                    addTocart(code, name, q, c, r,id);


                }
                else
                {
                    MessageBox.Show("Please enter a quantity.");
                }

            }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = authentication.connect();
            double profit = 0;
            double totalbill = 0;
            foreach (var item in cart)
            {

                totalbill += item.retail * (double)item.Quantity;
                profit += (item.retail-item.cost)*(double)item.Quantity;
                String query = $"UPDATE stock set qtty = qtty-{item.Quantity} WHERE(iid={item.id} AND qtty>0)";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int r = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }finally
                {
                    conn.Close();
                }             

            }
            String query2 = $"INSERT INTO bill(total,profit,date) VALUES({totalbill},{profit},CURDATE())";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query2, conn);
                int r = cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            {

            MessageBox.Show(ex.Message); 
            }finally
            {
                conn.Close();
            }




            cart.Clear();
            BindCartToGrid();
            MessageBox.Show("Thanx for comming!");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            this.Close();
            d.Show();
        }
    }
    public class CartItem
    {
        public int id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double retail { get; set; }
        public string ItemCode { get; set; }
        public double cost { get; set; }
        
    }
}
