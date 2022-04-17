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
    public partial class LoginFrm : Form
    {
        
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True");
            string query = "Select * from UserRegTable Where Username = '" + UsernameLog.Text.Trim() + "' and Password = '" + PassLog.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                global.uname = dtbl.Rows[0]["Username"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
                Dashboard2 dbshd = new Dashboard2();
                this.Hide();
                dbshd.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameLog.Text = "";
                PassLog.Text = "";
                UsernameLog.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsernameLog.Text = "";
            PassLog.Text = "";
            UsernameLog.Focus();
        }

        private void CheckPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassShow.Checked)
            {
                PassLog.PasswordChar = '\0';
                
            }
            else
            {
                PassLog.PasswordChar = '*';
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new RegisterFrm().Show();
            this.Hide();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLogin adl = new AdminLogin();
            this.Hide();
            adl.Show();
        }
    }
}
