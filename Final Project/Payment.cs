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
    public partial class Payment : Form
    {
        public static int id1;
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Payment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string crdt = credit.Text;
            if (crdt == "")
            {
                MessageBox.Show("Enter your credit number", "warning");
                return;
            }
            else if (crdt.Length != 16)
            {
                MessageBox.Show("Credit card has 16", "warning");
                return ;
            }
                MySqlConnection conn = databaseConnection();
                String sql1 = $"UPDATE checkflight SET creditcard = '" + credit.Text + "' WHERE id = '" + Departing.id1 + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                conn.Open();
                int rows1 = cmd1.ExecuteNonQuery();
                conn.Close();
                Ticket ticket = new Ticket();
                ticket.Show();
                this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "SELECT date1,depart,arrive,departflight,price FROM checkflight WHERE id = '" + Departing.id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                string date = dr.GetString("date1");
                string depart1 = dr.GetString("depart");
                string arrive1 = dr.GetString("arrive");
                string timedp = dr.GetString("departflight");
                string ttprice = dr.GetString("price");
                textBox1.Text = ("departdate" + "\r\n" + date + "\r\n"+"\r\n"+"" + depart1 + "------" + arrive1 + "\r\n" + timedp + "\r\n" +"\r\n" + "\r\n" + "Total Payment   " + ttprice + "  Bath");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sqli = $"DELETE nameofguest,birth,sex,email,tel FROM checkflight WHERE id = '" + id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sqli, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            Guest_Detail guest = new Guest_Detail();
            guest.Show();
            this.Hide();
        }

        private void credit_TextChanged(object sender, EventArgs e)
        {

        }

        private void credit_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
