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
    public partial class Flights : Form
    {
        public static string frm = "";
        public static string To = "";
        public static string wy = "";
        public static string date_go = "";
        private MySqlConnection databaseConnection()
        {
            String connectionString = "datasource = 127.0.01;port=3306;username=root;password=;database=airabc;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Flights()
        {
            InitializeComponent();
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            String wy = Way.Text;
            String clss = classes.Text;
            frm = from.Text;
            To = to.Text;
            if (wy == "-------Way------")
            {
                MessageBox.Show("choose way", "warning");
                return;
            }
            else if (clss == "------Class-----")
            {
                MessageBox.Show("choose class", "warning");
                return ;
            }
            else if (frm == "------From------")
            {
                MessageBox.Show("choose where depart", "warning");
                return;
            }
            else if (To == "--------To-------")
            {
                MessageBox.Show("choose where arrive", "warning");
                return;
            }
            String dte1 = Convert.ToDateTime(date_depart.Text).ToString("yyyy-MM-dd");
            //String dte2 = Convert.ToDateTime(date1.Text).ToString("yyyy-MM-dd");
            MySqlConnection conn = databaseConnection();
            string sql = "SELECT id FROM checkflight";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            List<int> allID = new List<int>();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                allID.Add(dr.GetInt32("id"));
            }
            conn.Close();

            int length = allID.Count;
            if (length == 0)
            {
                Departing.id1 = 1;
            }
            else
            {
                int id = allID[length - 1] + 1; 
                Departing.id1 = id;
            }
            date_go = date_depart.Value.ToString("dd-MM-yyyy");


            sql = $"INSERT INTO checkflight (id,way,class,depart,arrive,date1) VALUES ('{Departing.id1}','{wy}','{clss}','{frm}','{To}','{dte1}')";
            cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close(); 
            Departing departing = new Departing();
            departing.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Way_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void classes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
