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


    public partial class ViewLoginDetails : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public ViewLoginDetails()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminServerMonitor adminServerMonitor = new AdminServerMonitor();
            this.Hide();
            adminServerMonitor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from UserRegTable ", conn);

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
                SqlCommand cmd = new SqlCommand("select * from UserRegTable where Username = '" + username.Text + "' ", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void ViewLoginDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
