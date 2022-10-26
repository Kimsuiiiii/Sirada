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
    public partial class Departing : Form
    {
        private string depart = Flights.frm;
        private string arrive = Flights.To;
        private string way = Flights.wy;
        public static List<string> departtime = new List<string>();
        public static List<string> arrivetime = new List<string>();
        public static int price = 0;
        public static int id1 = 0;
        public static string flightID = "";
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        
        public Departing()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public string id(string depart_time, string arrive_time)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "SELECT id FROM flights WHERE depart = '" + depart + "' AND arrive = '" + arrive + "'"
                + " AND timetodepart = '" + depart_time + "' AND timetoarrive = '" + arrive_time + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            string id = "";
            if (dr.Read())
            {
                id = dr.GetString("id").PadLeft(5, '0');
            }
            conn.Close();
            return id;
        }

        private string[] gettime()
        {
            MySqlConnection conn = databaseConnection();
            string sql = "SELECT timetodepart, timetoarrive, Economy FROM flights WHERE depart = '" + depart + "' AND arrive = '" + arrive + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                departtime.Add(dr.GetString("timetodepart"));
                arrivetime.Add(dr.GetString("timetoarrive"));
                price = dr.GetInt32("Economy");
                list.Add(dr.GetString("timetodepart") + "     ***********     " + dr.GetString("timetoarrive") + "      " + price + "   Bath" + "\r\n" + depart + "     ***********     " + arrive);
            }
            conn.Close();
            return list.ToArray();
        }

        private void Departing_Load(object sender, EventArgs e)
        {
            string[] timelist = gettime();
            string text = "No flight";
            textBox1.Text = text;
            textBox2.Text = text;
            textBox3.Text = text;
            textBox4.Text = text;
            if (timelist.Length != 0)
            {
                for (int i = 1; i <= timelist.Length; i++)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox textbox = c as TextBox;
                            if (textbox.Name.Contains(i.ToString()))
                            {
                                textbox.Text = timelist[i - 1];
                            }
                        }
                        if (c is Button && c.Name.Contains(i.ToString()) && c.Text == "Select")
                        {
                            c.Visible = true;
                        }
                    }
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int buttonName = -1;
            switch (button.Name)
            {
                case "btn1":
                    buttonName = 0;
                    break;
                case "btn2":
                    buttonName = 1;
                    break;
                case "btn3":
                    buttonName = 2;
                    break;
                case "btn4":
                    buttonName = 3;
                    break;
                default:
                    buttonName = -1;
                    break;
            }
            if (buttonName != -1)
            {
                MySqlConnection conn = databaseConnection();
                String sqll = $"UPDATE checkflight SET price = '" + price + "' WHERE id = '" + id1 + "'";
                String sql1 = $"UPDATE checkflight SET departflight = '" + departtime[buttonName] + " - " + arrivetime[buttonName] + "' WHERE id = '" + id1 + "'";
                MySqlCommand cmd = new MySqlCommand(sqll, conn);
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                int rows1 = cmd1.ExecuteNonQuery();
                conn.Close();
                flightID = id(departtime[buttonName], arrivetime[buttonName]);
                pickseat ps = new pickseat();
                ps.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sqli = $"DELETE FROM checkflight WHERE id = '" + id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sqli, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            Flights flight = new Flights();
            flight.Show();
            this.Close();
        }
    }
}
