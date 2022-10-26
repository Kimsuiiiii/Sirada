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
    public partial class Login : Form
    {
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void credit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private bool login_correct(string username, string password)
        {
            MySqlConnection conn = databaseConnection();
            string sql = $"SELECT * FROM admin WHERE username = '{username}'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (login_correct(credit.Text, textBox1.Text))
            {
                MessageBox.Show("Login");
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Invalid username of password");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
