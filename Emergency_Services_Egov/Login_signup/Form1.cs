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
    public partial class RegisterFrm : Form
    {
        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public RegisterFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int MobileNum = int.Parse(Mobile.Text);


            if (UsernameReg.Text == "" && Mobile.Text == "" && PassReg.Text == "" && ConPassReg.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PassReg.Text == ConPassReg.Text  )
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserRegTable values ('" + UsernameReg.Text+ "', '" + int.Parse(Mobile.Text) + "','" + PassReg.Text + "',getdate())", conn);
                    //cmd.CommandType = CommandType.StoredProcedure;

                    //cmd.Parameters.AddWithValue("@Username", UsernameReg.Text.Trim());
                    //cmd.Parameters.AddWithValue("@MobileNo", Mobile.Text.Trim());
                    //cmd.Parameters.AddWithValue("@Password", PassReg.Text.Trim());

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Your account has successfully created", "Registration Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PassReg.Text = "";
                    ConPassReg.Text = "";
                    PassReg.Focus();


                    UsernameReg.Text = "";
                    PassReg.Text = "";
                    ConPassReg.Text = "";

                   conn.Close();
                }
            }
            else
            {
              
                   MessageBox.Show("Please provide proper information", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PassReg.Text = "";
                    ConPassReg.Text = "";
                    PassReg.Focus();
                
            }
        }

        private void CheckPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckPassShow.Checked)
            {
                PassReg.PasswordChar = '\0';
                ConPassReg.PasswordChar = '\0';
            }
            else
            {
                PassReg.PasswordChar = '*';
                ConPassReg.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsernameReg.Text = "";
            PassReg.Text = "";
            ConPassReg.Text = "";
            UsernameReg.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //new Dashbord().Show();
            //this.Hide();
            new LoginFrm().Show();
            this.Hide();
        }

        private void RegisterFrm_Load(object sender, EventArgs e)
        {

        }

        private void Mobile_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
    }
