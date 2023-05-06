using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class UpdateDelete : Form
    {
        
        public UpdateDelete()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R29FKDI\SQLEXPRESS;Initial Catalog=GYMDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter SDa = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            SDa.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            populate();
       
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int key=0;
      
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dataGridView1 = new DataGridView();


            key = Convert.ToInt32(MemberSDGV.SelectedRows[0].Cells[0].Value.ToString());
            txtName.Text = MemberSDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = MemberSDGV.SelectedRows[0].Cells[2].Value.ToString();
            cmbgender.Text = MemberSDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtAge.Text = MemberSDGV.SelectedRows[0].Cells[4].Value.ToString();
            cmbPlan.Text = MemberSDGV.SelectedRows[0].Cells[5].Value.ToString();
            cmbTiming.Text = MemberSDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Member To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTbl where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Deleted Succesfully");
                    Con.Close();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (key == 0 || txtName.Text == "" || txtPhone.Text == "" || txtAge.Text == "" || cmbgender.Text == ""|| cmbPlan.Text == ""|| cmbTiming.Text == "")
           
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update MemberTbl set Mname='"+txtName.Text+"',MPhone='"+txtPhone.Text+"',MGender='"+cmbgender.Text+"',MAge='"+txtAge.Text+"',MPlan='"+cmbPlan.Text+"',MTiming='"+cmbTiming+"'where MId="+key+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Updated Succesfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
