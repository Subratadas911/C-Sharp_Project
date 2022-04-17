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
    public partial class epass2 : Form
    {
        public epass2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            E_passport e_Passport = new E_passport();
            this.Hide();
            e_Passport.Show();
        }
    }
}
