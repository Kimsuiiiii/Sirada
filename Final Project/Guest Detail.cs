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
using System.Text.RegularExpressions;

namespace Final_Project
{
    public partial class Guest_Detail : Form
    {
        public static int id1;
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Guest_Detail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (firstname.Text == "First name")
            {
                firstname.Clear();
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (surname.Text == "Surname")
            {
                surname.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_click(object sender, EventArgs e)
        {
            if (email.Text == " E-mail address")
            {
                email.Clear();
            }
        }

        private void tel_click(object sender, EventArgs e)
        {
            if (tel.Text == " Tel.")
            {
                tel.Clear();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sql = $"UPDATE checkflight SET sex = 'Male' WHERE id = '" + Departing.id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows1 = cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sql = $"UPDATE checkflight SET sex = 'Female' WHERE id = '" + Departing.id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows1 = cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void tel_keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            } else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        private void firstname_keypress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }

        private void surname_keypress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String frst = firstname.Text;
            String sur = surname.Text;
            String email1 = email.Text;
            String Tel = tel.Text;
            String ID = id.Text;
            bool ok = true;
            if (frst == "" || frst == "Firstname")
            {
                MessageBox.Show("Please enter your firstname", "warning");
                ok = false;
            }
            else if (sur == "" || sur == "Surname")
            {
                MessageBox.Show("Please enter your surname", "warning");
                ok = false;
            }
            else if (email1 == "" || email1 == "E-mail address")
            {
                MessageBox.Show("Please enter your email", "warning");
                ok = false;
            }
            else if (Tel == "" || Tel == "Tel.")
            {
                MessageBox.Show("Please enter your Tel.", "warning");
                ok = false;
            }
            else if (Tel.Length != 10)
            {
                MessageBox.Show("Phone number has 10","warning");
                ok = false;
            }
            else if (ID.Length != 13)
            {
                MessageBox.Show("ID number has 13", "warning");
                ok = false;
            }

            if (ok == true)
            {
                String dte1 = birth.Value.ToString("yyyy-MM-dd");
                String name = frst + " " + sur;
                MySqlConnection conn = databaseConnection();
                String sql = $"UPDATE checkflight SET nameofguest = '{name}',birth = '{dte1}',email = '{email1}',tel = '{Tel}',id_passport = '{ID}' WHERE id = '" + Departing.id1 + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                sql = $"UPDATE pickaseat SET tel = '{Tel}' WHERE date = '{Flights.date_go}' AND flight = '{Departing.flightID}' AND seat = '{pickseat.seat_selected}'";
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Payment payment = new Payment();
                payment.Show();
                this.Hide();
            }
            
        }

        private void Guest_Detail_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sqli = $"DELETE insurance FROM checkflight WHERE id = '" + id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sqli, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            Add_ons addon = new Add_ons();
            addon.Show();
            this.Hide();
        }

        private bool email_check(string email)
        {
            if (email.Contains("@")) // test@test.com
            {
                string[] email_text = email.Split('@');
                if (email_text[0].Length > 0 && email_text[1].Length > 0)
                {
                    if (email_text[1].Contains('.'))
                    {
                        string[] domain = email_text[1].Split('.');
                        if (domain[1].Length > 0)
                        {
                            return true;
                        }

                    }
                }

            }
            return false;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            bool check = email_check(email.Text);
            if (check == true)
            {
                button3.Enabled = true;
            } else
            {
                button3.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void id_Click(object sender, EventArgs e)
        {
            if (id.Text == " ID / Passport")
            {
                id.Clear();
            }
        }
    }
}
