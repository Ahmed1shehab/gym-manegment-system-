using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            uid.Text = "";
            pass.Text = "";
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (uid.Text == "" || pass.Text == "")
            {
                MessageBox.Show(" Missing Information");
            }else if (uid.Text =="Admin" && pass.Text=="Admin")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();

            }else
            {
                MessageBox.Show(" Wrong ID or Password ");
            }
        }
    }
}
