using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnflght_Click(object sender, EventArgs e)
        {
            Flights flights = new Flights();
            flights.Show();
            this.Hide();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
