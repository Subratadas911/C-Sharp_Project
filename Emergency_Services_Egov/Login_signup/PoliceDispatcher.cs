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
    public partial class PoliceDispatcher : Form
    {

        string connectionString = @"Data Source=DESKTOP-7RJVRRQ;Initial Catalog=EgovProject;Integrated Security=True";
        public PoliceDispatcher()
        {
            InitializeComponent();
        }

        private void PoliceDispatcher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 dbshd = new Dashboard2();
            this.Hide();
            dbshd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(pds.Text != "" && LC.Text != "")
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into PoliceDispatcher values ('" + int.Parse(pds.Text) + "', '" + LC.Text + "','" + CM.Text + "',getdate())", conn);
                    

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Your request has submitted successfully", "Help is comming!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    conn.Close();
                }


            }
            else
            {
                MessageBox.Show("Please provide proper information", "submission Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pds.Text = "";
                LC.Text = "";
                CM.Text="";
                pds.Focus();
            }
        }
    }
}
