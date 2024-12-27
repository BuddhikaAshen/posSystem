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
    public partial class Item_Register : Form
    {
        public Item_Register()
        {
            InitializeComponent();            
        }
        

        private void btnaddcat_Click(object sender, EventArgs e)
        {
            //String connString = "server=127.0.0.1; user=root; database=pos; password=";
            MySqlConnection conn = authentication.connect();

            try
            {
                String cat = txtaddcat.Text;
                String query = $"INSERT INTO category(category) VALUES('{cat}')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                cbcat.Items.Clear();
                loaddropdown();
                if (r == 1) MessageBox.Show("category registered success!");
                txtaddcat.Text = "";
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }finally
            {
                conn.Close();
            }

            
        }

        private void Item_Register_Load(object sender, EventArgs e)
        {
            loaddropdown();
        }
        public void loaddropdown()
        {
            MySqlConnection conn = authentication.connect();

            try
            {
                conn.Open();
                String query = $"SELECT * FROM category";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String cat = reader.GetString("category");
                    cbcat.Items.Add(cat);
                }
            }catch (Exception ex)
            {

            MessageBox.Show(ex.Message); 
            }finally
            {
                conn.Close();
            }
        }

        private void btniadd_Click(object sender, EventArgs e)
        {
            String name = txtiname.Text;
            String code = txticode.Text;
            String cat = cbcat.Text;
            double cost = Convert.ToDouble(txticost.Text);
            double retail = Convert.ToDouble(txticost.Text);

            MySqlConnection conn = authentication.connect();
            try
            {
                conn.Open();
                String query = $"INSERT INTO item(code,name,category,cost,retail) VALUES('{code}','{name}','{cat}',{cost},{retail})";
                MySqlCommand cmd = new MySqlCommand(query , conn);
                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    MessageBox.Show("Item Registerd Success!");
                    txticode.Text = "";
                    txticost.Text = "";
                    txtiname.Text = "";
                    txtiret.Text = "";

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

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard d = new dashboard();
            this.Close();
            d.Show();
        }
    }
}
