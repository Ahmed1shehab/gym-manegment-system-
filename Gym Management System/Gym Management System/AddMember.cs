using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    

namespace Gym_Management_System
{
    public partial class AddMember : Form
    {
        public static AddMember instance;
        public AddMember()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 600;
            instance=this ;
            this.MinimizeBox = true;
            this.ControlBox = true;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R29FKDI\SQLEXPRESS;Initial Catalog=GYMDb;Integrated Security=True");
        private void AddMember_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
        }

 

     

        private void lblexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="" || txtPhoneNumber.Text==""|| txtAge.Text=="")
            {
                MessageBox.Show("Missing information");

            }
            else
            {
                try {


                    Con.Open();
                    string query = "INSERT INTO MemberTbl VALUES ( '" + txtName.Text + "','" + txtPhoneNumber.Text + "','" + cmbgender.SelectedItem.ToString() + "','" + txtAge.Text + "','" + cmbPlan.SelectedItem.ToString() + "','" + cmbTiming.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    Con.Close();
                    txtAge.Text = "";
                    txtName.Text = "";
                    txtPhoneNumber.Text = "";
                    cmbTiming.Text = "";
                    cmbPlan.Text = "";
                    cmbgender.Text = "";
                }
                catch(Exception EX )
                {
                    MessageBox.Show(EX.Message);
                }



            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            cmbTiming.Text = "";
            cmbPlan.Text = "";
            cmbgender.Text = "";
        }

        private void btbback_Click(object sender, EventArgs e)
        {
            MainForm log = new MainForm();
            log.Show();
            this.Hide();
        }
    }
}
