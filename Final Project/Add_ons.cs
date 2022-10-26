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
    public partial class Add_ons : Form
    {
        public static int id1;
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Add_ons()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            int prices = Departing.price + 119;
            String sql1 = $"UPDATE checkflight SET insurance = 'apply' WHERE id = '" + Departing.id1 + "'";
            String sql = $"UPDATE checkflight SET price = '" + prices + "' WHERE id = '" + Departing.id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            int rows1 = cmd1.ExecuteNonQuery();
            conn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sql1 = $"UPDATE checkflight SET insurance = 'do not apply' WHERE id = '" + Departing.id1 + "'";
            MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
            conn.Open();
            int rows1 = cmd1.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guest_Detail detail = new Guest_Detail();
            detail.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sqli = $"DELETE FROM checkflight WHERE id = '" + Departing.id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sqli, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            pickseat ps = new pickseat();
            ps.Show();
            this.Hide();
        }

        private void Add_ons_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
