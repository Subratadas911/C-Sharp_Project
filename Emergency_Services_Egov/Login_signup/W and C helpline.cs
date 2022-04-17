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
    public partial class W_and_C_helpline : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public W_and_C_helpline()
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
            if (a.Text != "" && b.Text != "" && c.Text !="")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into WChelpLine values ('" + a.Text + "', '" + int.Parse(b.Text) + "','" + int.Parse(c.Text) + "','" + d.Text + "',getdate())", conn);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Your request has submitted successfully and we are responsing as fast as posible", "Help is comming!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                a.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";
            a.Focus();
        }
    }
    }

