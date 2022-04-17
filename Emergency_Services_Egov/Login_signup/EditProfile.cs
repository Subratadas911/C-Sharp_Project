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
    public partial class EditProfile : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public EditProfile()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Dashboard2 dbshd = new Dashboard2();
            this.Hide();
            dbshd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update UserRegTable set Username=@Username, Password=@Password where MobileNo = @MobileNo", conn);
                cmd.Parameters.AddWithValue("@Username", a.Text);
                cmd.Parameters.AddWithValue("@MobileNo", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Password", b.Text);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Your details updated succesfully");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
