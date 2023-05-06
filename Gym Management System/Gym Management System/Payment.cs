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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R29FKDI\SQLEXPRESS;Initial Catalog=GYMDb;Integrated Security=True");
        private void FillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Mname from MemberTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mname", typeof(string));
            dt.Load(rdr);
            cmbNAme.ValueMember = "Mname";
            cmbNAme.DataSource= dt;
            Con.Close();
        }
        private void Filterbyname()
        {
            Con.Open();
            string query = "select * from PaymentTbl where PMember='"+txtsearchname+"'";
            SqlDataAdapter SDa = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            SDa.Fill(ds);
            paymentSDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void populate()
        {
            Con.Open();
            string query = "select * from PaymentTbl";
            SqlDataAdapter SDa = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            SDa.Fill(ds);
            paymentSDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void btbback_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
          //  txtName.Text = "";
            txtAmount.Text = "";
        }
        int key = 1;
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbNAme.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                string payperiode= period.Value.Month.ToString()+period.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTbl where PMember='"+cmbNAme.SelectedValue.ToString()+"'and PMonth='"+payperiode+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show(" ALready Paid For This Months=");
                }else
                {
                    string query = "insert into PaymentTbl values('" + payperiode + "','" + cmbNAme.SelectedValue.ToString() + "','" + txtAmount.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid succesfully");
                }
                
                Con.Close();
                populate();
            }
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void seachbtn_Click(object sender, EventArgs e)
        {
            Filterbyname();
            txtsearchname.Text = "";

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
