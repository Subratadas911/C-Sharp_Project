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

    
    public partial class covid_19Services : Form
    {


        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public covid_19Services()
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
            if(a.Text != "" && b.Text != "" && c.Text != "" && d.Text != "" && mbl.Text !="")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Covid19HelpLine values ('" + a.Text + "', '" + b.Text + "','" + c.Text + "','" + d.Text + "','" + mbl.Text + "','" + f.Text + "',getdate())", conn);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Your request has submitted successfully", "Desco service is on way!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Please provide proper information", "submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                a.Text = "";
                b.Text = "";
                c.Text = "";
                d.Text = "";
                mbl.Text = "";
                f.Text = "";
                a.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";
            mbl.Text = "";
            f.Text = "";
            a.Focus();
        }
    }
    }

