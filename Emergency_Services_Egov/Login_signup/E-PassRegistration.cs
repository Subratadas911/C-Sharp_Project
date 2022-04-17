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
    public partial class E_PassRegistration : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public E_PassRegistration()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard2 dbshd = new Dashboard2();
            this.Hide();
            dbshd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flname.Text = "";
            dob.Text = "";
            nid.Text = "";
            PA.Text = "";
            flname.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(flname.Text != "" && dob.Text !="" && gender.Text !=""&& nid.Text != "" && PA.Text !="")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into ePassPort values ('" + flname.Text + "', '" + dob.Text + "','" + gender.Text + "','" + nid.Text + "','" + PA.Text + "',getdate())", conn);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Your details has submitted successfully, you will get your passport withing 30 days by authentication", "Your request is processing!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Please provide proper information", "submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flname.Text = "";
                dob.Text = "";
                nid.Text = "";
                PA.Text = "";
                flname.Focus();
            }
        }
        }
    }

