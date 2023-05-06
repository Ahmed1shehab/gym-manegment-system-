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
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-R29FKDI\SQLEXPRESS;Initial Catalog=GYMDb;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTbl";
            SqlDataAdapter SDa = new SqlDataAdapter(query ,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            SDa.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            populate();

        }

        private void btbback_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void Filterbyname()
        {
            Con.Open();
            string query = "select * from MemberTbl where Mname='" + txtName + "'";
            SqlDataAdapter SDa = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            SDa.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            Filterbyname();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
