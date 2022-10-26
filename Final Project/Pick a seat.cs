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
    public partial class pickseat : Form
    {
        public static string seat_selected = "";
        private Button lastbutton = null;
        private Color base_color = Color.LavenderBlush;
        MySqlConnection conn = new MySqlConnection("datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;");

        public pickseat()
        {
            InitializeComponent();

            foreach (Control c in this.Controls)
            {
                seatButtonClickEvent(c);
            }
        }

        private string[] seat_code = { "A", "B", "C", "D", "E", "F" };
        private void seatButtonClickEvent (Control c)
        {
            if (c is Button)
            {
                for (int i = 0; i < seat_code.Length; i++)
                {
                    if (c.Text.Contains(seat_code[i]))
                    {
                        c.Click += seatButton_Click;
                    }
                }
            }
            foreach (Control control in c.Controls)
            {
                seatButtonClickEvent(control);
            }
        }

        private string[] all_seat(string flight)
        {
            string sql = $"SELECT * FROM pickaseat WHERE flight = '{flight}' AND date = '{Flights.date_go}'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            List<string> list = new List<string>();
            while (reader.Read())
            {
                list.Add(reader.GetString("seat"));
            }
            conn.Close();
            return list.ToArray();
        }

        private bool check_seat(string flight, string seat)
        {
            string sql = $"SELECT * FROM pickaseat WHERE flight = '{flight}' AND seat = '{seat}' AND date = '{Flights.date_go}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.GetString("status") == "True")
                {
                    return true;
                }
            }
            conn.Close();

            return false;
        }

        private void change_seat_color(string flight)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    if (c.BackColor == Color.MediumAquamarine)
                    {
                        c.BackColor = base_color;
                    }
                }
            }
            foreach (string seat in all_seat(flight))
            {
                string sql = $"SELECT * FROM pickaseat WHERE flight = '{flight}' AND seat = '{seat}' AND date = '{Flights.date_go}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                List<string> list = new List<string>();
                while (reader.Read())
                {
                    list.Add(reader.GetString("status"));
                }
                conn.Close();

                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        foreach (string s in list)
                        {
                            if (c.Text == seat && s == "True")
                            {
                                c.BackColor = Color.Red;
                                c.Enabled = false;
                            }
                            else if (c.Text == seat && s == "False")
                            {
                                c.BackColor = base_color;
                                c.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void changecolor(Button current)
        {
            if (lastbutton != null)
            {
                change_seat_color(Departing.flightID);
            }
            lastbutton = current;
            current.BackColor = Color.MediumAquamarine;
        }

        private void pickseat_Load(object sender, EventArgs e)
        {
            change_seat_color(Departing.flightID);
        }

        private void seatButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            changecolor(button);
            seat_selected = button.Text;
            button.BackColor = Color.MediumAquamarine;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seat_selected))
            {
                MessageBox.Show("Please fix your seat", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string sql = $"SELECT * FROM pickaseat WHERE flight = '{Departing.flightID}' AND seat = '{seat_selected}' AND date = '{Flights.date_go}'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                if (!dr.HasRows)
                {
                    sql = $"INSERT INTO pickaseat (date, flight, seat, status) VALUES ('{Flights.date_go}','{Departing.flightID}','{seat_selected}','True')";
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    sql = $"UPDATE checkflight SET seat = '{seat_selected}' WHERE id = '" + Departing.id1 + "'";
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                } else if (dr.HasRows && check_seat(Departing.flightID, seat_selected) == false) 
                {
                    sql = $"UPDATE pickaseat SET status = 'True' WHERE date = '{Flights.date_go}' AND flight = '{Departing.flightID}' AND seat = '{seat_selected}'";
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    sql = $"UPDATE checkflight SET seat = '{seat_selected}' WHERE id = '" + Departing.id1 + "'";
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                } else
                {
                    MessageBox.Show("seat not available");
                    conn.Close();
                }
                Add_ons addon = new Add_ons();
                addon.Show();
                this.Hide();
            }
        }

        private void button108_Click(object sender, EventArgs e)
        {
            Departing departing = new Departing();
            departing.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
