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
    public partial class Edit : Form
    {
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private string flightID = "";

        private void showData()
        {
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM flights";

            conn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            adapter.Fill(ds);
            conn.Close();

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            flightID = dataGridView1.Rows[selectedRow].Cells["id"].FormattedValue.ToString();
            from.Text = dataGridView1.Rows[selectedRow].Cells["depart"].FormattedValue.ToString();
            to.Text = dataGridView1.Rows[selectedRow].Cells["arrive"].FormattedValue.ToString();
            textBox1.Text = dataGridView1.Rows[selectedRow].Cells["timetodepart"].FormattedValue.ToString();
            textBox2.Text = dataGridView1.Rows[selectedRow].Cells["timetoarrive"].FormattedValue.ToString();
            textBox3.Text = dataGridView1.Rows[selectedRow].Cells["Economy"].FormattedValue.ToString();
        }

        private bool checkExist(string type)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "";
            if (type == "id")
            {
                sql = $"SELECT * FROM flights WHERE id = '{flightID}'";
            } else if (type == "data")
            {
                sql = $"SELECT * FROM flights WHERE depart = '{from.Text}' AND arrive = '{to.Text}' and timetodepart = '{textBox1.Text}' AND timetoarrive = '{textBox2.Text}'";
            }
            
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkExist("data"))
            {
                MySqlConnection conn = databaseConnection();

                string sql = $"INSERT INTO flights (depart,arrive,timetodepart,timetoarrive,Economy) VALUES ('{from.Text}','{to.Text}','{textBox1.Text}','{textBox2.Text}','{textBox3.Text}')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Added Flights");
            }
            else
            {
                MessageBox.Show("Flight is exist!");
            }

            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkExist("id"))
            {
                DialogResult result = MessageBox.Show("Confirm", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = databaseConnection();

                    string sql = $"DELETE FROM flights WHERE id = '{flightID}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Deleted Flights");
                }
            }
            else
            {
                MessageBox.Show("Flight is not exist!");
            }

            showData();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkExist("id"))
            {
                DialogResult result = MessageBox.Show("Confirm", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = databaseConnection();

                    string sql = $"UPDATE flights SET depart = '{from.Text}', arrive = '{to.Text}', timetodepart = '{textBox1.Text}', timetoarrive = '{textBox2.Text}', Economy = '{textBox3.Text}' WHERE id = '{flightID}'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Edited Flights");
                }
            }
            else
            
                MessageBox.Show("Flight is not exist!");
            }

            showData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}
