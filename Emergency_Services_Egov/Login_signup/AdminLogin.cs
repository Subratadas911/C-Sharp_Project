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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            this.Hide();
            loginFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True");
            string query = "Select * from AdminDetails Where Username = '" + UsernameLog.Text.Trim() + "' and Password = '" + PassLog.Text.Trim() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {

                AdminServerMonitor monitor = new AdminServerMonitor();
                this.Hide();
                monitor.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UsernameLog.Text = "";
                PassLog.Text = "";
                UsernameLog.Focus();
            }
            
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
    }
}
