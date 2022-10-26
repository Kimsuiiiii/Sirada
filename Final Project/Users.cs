using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Final_Project
{
    
    public partial class Users : Form
    {
        public static int price = 0;
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Users()
        {
            InitializeComponent();
        }

        private void showData()
        {
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                cmd.CommandText = "SELECT * FROM checkflight";
            } else
            {
                cmd.CommandText = $"SELECT * FROM checkflight WHERE nameofguest LIKE '%{textBox1.Text}%' OR tel LIKE '%{textBox1.Text}%'";
            }

            if (checkBox1.Checked == false)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    cmd.CommandText += " WHERE ";
                } else
                {
                    cmd.CommandText += " AND ";
                }
                cmd.CommandText += " date1 >= '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' AND date1 <= '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
            }
            
            conn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(ds);
            conn.Close();

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            showData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            price = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                price += Convert.ToInt32(dataGridView1.Rows[i].Cells["price"].Value);
            }
            textBox2.Text = price.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("time not correct.");
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
            showData();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            } else
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            showData();
        }
    }
}
