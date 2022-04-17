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
    public partial class AdminWomenChildHelp : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public AdminWomenChildHelp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminServerMonitor adminServerMonitor = new AdminServerMonitor();
            this.Hide();
            adminServerMonitor.Show();
        }

        private void AdminWomenChildHelp_Load(object sender, EventArgs e)
        {

        }
        void BindData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from WChelpLine ", conn);

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
                SqlCommand cmd = new SqlCommand("select * from WChelpLine where MobileNo = '" + int.Parse(mbl.Text) + "' ", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete WChelpLine where MobileNo = '" + int.Parse(mbl.Text) + "' ", conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("user request deleted succesfully");
                BindData();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
