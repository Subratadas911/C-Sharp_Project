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
    public partial class AdminAmbulanceDispatcher : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public AdminAmbulanceDispatcher()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminServerMonitor adminServerMonitor = new AdminServerMonitor();
            this.Hide();
            adminServerMonitor.Show();
        }

        private void AdminAmbulanceDispatcher_Load(object sender, EventArgs e)
        {

        }
        void BindData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from AmbulanceDispatcher ", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from AmbulanceDispatcher where Mobile = '" + int.Parse(mobile.Text) + "' ", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete AmbulanceDispatcher where Mobile = '" + int.Parse(mobile.Text) + "' ", conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("user request deleted succesfully");
                BindData();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
