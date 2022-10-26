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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();  
            users.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
