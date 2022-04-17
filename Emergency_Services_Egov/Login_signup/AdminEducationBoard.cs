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
    public partial class AdminEducationBoard : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public AdminEducationBoard()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete EducationBRD where RegistrationNo = '" + int.Parse(tbl.Text) + "' ", conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("user  deleted succesfully");
                BindData();

            }
        }

        private void AdminEducationBoard_Load(object sender, EventArgs e)
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
                
                SqlCommand dmd = new SqlCommand("select * from EducationBRD where RegistrationNo = '" + int.Parse(tbl.Text) + "' ", conn);
                
                SqlDataAdapter adapter = new SqlDataAdapter(dmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void db_Click(object sender, EventArgs e)
        {
            AdminServerMonitor monitor = new AdminServerMonitor();
            this.Hide();
            monitor.Show();
        }
    }
}
