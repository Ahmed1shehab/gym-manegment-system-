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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 600;
        }

        private void picmain_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddMember s = new AddMember();
            s.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdatedelete_Click(object sender, EventArgs e)
        {
            UpdateDelete delete = new UpdateDelete();
            delete.Show();
            this.Hide();


        }

      

        private void btnpayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();

        }

        private void btntrainers_Click(object sender, EventArgs e)
        {
            Trainers trainers = new Trainers();
                trainers.Show();
            this.Hide();

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewmember_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }
    }
}
