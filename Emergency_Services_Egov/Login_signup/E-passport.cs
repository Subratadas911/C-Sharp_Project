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
    public partial class E_passport : Form
    {
        public E_passport()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            E_PassRegistration epsds = new E_PassRegistration();
            this.Hide();
            epsds.Show();
        }

        private void E_passport_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Epass1 pass1 = new Epass1();
            this.Hide();
            pass1.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            epass2 epass2 = new epass2();
            this.Hide();
            epass2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard2 fr = new Dashboard2();
            this.Hide();
            fr.Show();
        }
    }
}
