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
    public partial class Desco : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public Desco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 dbshd = new Dashboard2();
            this.Hide();
            dbshd.Show();
        }

        private void Desco_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if( A.Text != "" && b.Text !="")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into Desco values ('" + int.Parse(A.Text) + "', '" + b.Text + "','" + c.Text + "',getdate())", conn);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Your request has submitted successfully", "Desco service is on way!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Please provide proper information", "submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                A.Text = "";
                b.Text = "";
                c.Text = "";
                A.Focus();
            }
        }
        }
    }

