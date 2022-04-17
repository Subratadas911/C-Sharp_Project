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
    public partial class Epass1 : Form
    {
        public Epass1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            E_passport e_Passport = new E_passport();
            this.Hide();
            e_Passport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 dashboard2 = new Dashboard2();
            this.Hide();
            dashboard2.Show();
        }
    }
}
