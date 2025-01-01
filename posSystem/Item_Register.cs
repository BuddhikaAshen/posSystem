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
    public partial class Item_Register : Form
    {
        public Item_Register()
        {
            InitializeComponent();            
        }
        

        private void btnaddcat_Click(object sender, EventArgs e)
        {
            //String connString = "server=127.0.0.1; user=root; database=pos; password=";
            SqlConnection conn = authentication.connect();

            try
            {
                String cat = txtaddcat.Text;
                String query = $"INSERT INTO [category](category) VALUES('{cat}')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
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
            SqlConnection conn = authentication.connect();

            try
            {
                conn.Open();
                String query = $"SELECT * FROM [category]";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String cat = reader["category"].ToString();
                    cbcat.Items.Add(cat);
                }
                reader.Close();

                String query2 = $"SELECT * FROM [supplier]";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    String sup = reader2["name"].ToString();
                    cbsup.Items.Add(sup);
                }
                reader2.Close();



            }
            catch (Exception ex)
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
            String sup = cbsup.Text;
            

            SqlConnection conn = authentication.connect();
            try
            {
                conn.Open();
                //String query = $"INSERT INTO [item](code,name,category,cost,retail,sid) VALUES('{code}','{name}','{cat}',{cost},{retail},(select id from [supplier] where name={sup}))";
                String query = $"INSERT INTO [item](code, name, category,sid) VALUES ('{code}', '{name}', '{cat}', (SELECT id FROM [supplier] WHERE name = '{sup}'))";
                SqlCommand cmd = new SqlCommand(query , conn);
                int r = cmd.ExecuteNonQuery();
                if (r == 1)
                {
                    MessageBox.Show("Item Registerd Success!");
                    txticode.Text = "";
                   
                    txtiname.Text = "";
                    

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

        private void btnback_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
