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
    public partial class FireDispatcher : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public FireDispatcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 dbshd = new Dashboard2();
            this.Hide();
            dbshd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked || checkBox2.Checked && FDS.Text !="" && LC.Text !="" )
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into FireDispatcher values ('" + int.Parse(FDS.Text) + "', '" + LC.Text + "','" + cmnt.Text + "',getdate())", conn);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Your request has submitted successfully", "Help is comming!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Please provide proper information", "submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FDS.Text = "";
                LC.Text = "";
                cmnt.Text = "";
                FDS.Focus();
            }
        }

        private void FireDispatcher_Load(object sender, EventArgs e)
        {

        }
    }
    }

