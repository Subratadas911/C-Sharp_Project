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
    public partial class UpdateAllUser : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public UpdateAllUser()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           AdminServerMonitor adminServerMonitor = new AdminServerMonitor();
            this.Hide();
            adminServerMonitor.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (UsernameReg.Text == "" && Mobile.Text == "" && PassReg.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Data Insertion failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameReg.Text = "";
                Mobile.Text = "";
                PassReg.Text = "";

                UsernameReg.Focus();

            }
            else 
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserRegTable values ('" + UsernameReg.Text + "', '" + int.Parse(Mobile.Text) + "','" + PassReg.Text + "',getdate())", conn);
                    //cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.AddWithValue("@Username", UsernameReg.Text.Trim());
                    //cmd.Parameters.AddWithValue("@MobileNo", Mobile.Text.Trim());
                    //cmd.Parameters.AddWithValue("@Password", PassReg.Text.Trim());

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Your account has successfully created", "Registration Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UsernameReg.Text = "";
                    Mobile.Text = "";
                    PassReg.Text = "";
                    
                    UsernameReg.Focus();


                    conn.Close();
                    BindData();
                }
            }
            
        }
        void BindData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from UserRegTable ", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt =new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource=dt;

                    }
        }

        private void MobileUpdateAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            UsernameReg.Text = "";
            Mobile.Text = "";
            PassReg.Text = "";
           
            UsernameReg.Focus();
        }

        private void UpdateAllUser_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update UserRegTable set Username=@Username, Password=@Password where MobileNo = @MobileNo", conn);
                cmd.Parameters.AddWithValue("@Username", UsernameReg.Text);
                //cmd.Parameters.AddWithValue("@MobileNo", int.Parse(Mobile.Text));
                cmd.Parameters.AddWithValue("@Password", PassReg.Text);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("user details updated succesfully");
                BindData();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete UserRegTable where MobileNo = '"+ int.Parse(Mobile.Text)+"' ", conn);
                
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("user deleted succesfully");
                BindData();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from UserRegTable where Username = '"+UsernameReg.Text+"' ", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
