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
    public partial class Ticket : Form
    {
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "SELECT date1,depart,arrive,departflight,nameofguest,seat FROM checkflight WHERE id = '" + Departing.id1 + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                string date = dr.GetString("date1");
                string depart = dr.GetString("depart");
                string arrive = dr.GetString("arrive");
                string timedp = dr.GetString("departflight");
                string guest = dr.GetString("nameofguest");
                string seat = dr.GetString("seat");

                textboxdate.Text = date;
                textBoxdepart.Text = depart;
                textBoxarrive.Text = arrive;
                textBoxtime.Text = timedp.Split('-')[0];
                textboxname.Text = guest;
                textBoxseat.Text = seat;
            }
            conn.Close();



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
