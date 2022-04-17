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

namespace Login_signup
{
    public partial class EducationBoard : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public EducationBoard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void BindData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from EducationBRD ", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from EducationBRD where Examination = '" + tb1.Text + "' ",  conn);
                SqlCommand amd = new SqlCommand("select * from EducationBRD where Year = '" + int.Parse(tb2.Text) + "' ", conn);
                SqlCommand bmd = new SqlCommand("select * from EducationBRD where Board = '" + tb3.Text + "' ", conn);
                SqlCommand dmd = new SqlCommand("select * from EducationBRD where RegistrationNo = '" + int.Parse(textBotb4x3.Text) + "' ", conn);
                SqlCommand xmd = new SqlCommand("select * from EducationBRD where RollNo = '" + int.Parse(tb5.Text) + "' ", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard2 = new Dashboard2();
            this.Hide();
            dashboard2.Show();
        }
    }
}
