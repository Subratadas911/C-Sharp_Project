using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_signup
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            
            //this.Show(first1.ActiveControl);
           // this.first1.Visible = true;
           
        }

        private void first1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterFrm rs = new RegisterFrm();
            this.Hide();
            rs.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginFrm ls = new LoginFrm();
            this.Hide();
            ls.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
