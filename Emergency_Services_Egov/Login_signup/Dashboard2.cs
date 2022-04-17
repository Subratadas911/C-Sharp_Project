using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login_signup
{
    public partial class Dashboard2 : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse
   );

        public Dashboard2()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNV.Height = YourProfile.Height;
            PnlNV.Top = YourProfile.Top;
            PnlNV.Left = YourProfile.Left;
            PnlNV.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {

        }

        private void YourProfile_Click(object sender, EventArgs e)
        {
            PnlNV.Height = YourProfile.Height;
            PnlNV.Top = YourProfile.Top;
            PnlNV.Left = YourProfile.Left;
            PnlNV.BackColor = Color.FromArgb(46, 51, 73);
            YourProfile ypf = new YourProfile();
            this.Hide();
            ypf.Show();
        }

        private void EditProfile_Click(object sender, EventArgs e)
        {
            PnlNV.Height = EditProfile.Height;
            PnlNV.Top = EditProfile.Top;
            PnlNV.Left = EditProfile.Left;
            PnlNV.BackColor = Color.FromArgb(46, 51, 73);
            EditProfile ypfl = new EditProfile();
            this.Hide();
            ypfl.Show();

           
        }

        private void Calender_Click(object sender, EventArgs e)
        {
            PnlNV.Height = Calender.Height;
            PnlNV.Top = Calender.Top;
            PnlNV.Left = Calender.Left;
            PnlNV.BackColor = Color.FromArgb(46, 51, 73);

            
            

        }

        private void Home_Click(object sender, EventArgs e)
        {
            PnlNV.Height = Home.Height;
            PnlNV.Top = Home.Top;
            PnlNV.Left = Home.Left;
            PnlNV.BackColor = Color.FromArgb(46, 51, 73);

            Dashbord dsh = new Dashbord();
            this.Hide();
            dsh.Show();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            PnlNV.Height = Settings.Height;
            PnlNV.Top = Settings.Top;
            PnlNV.Left = Settings.Left;
            PnlNV.BackColor = Color.FromArgb(46, 51, 73);

            this.BackColor = System.Drawing.Color.Black;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            PnlNV.Height = Logout.Height;
            PnlNV.Top = Logout.Top;
            PnlNV.Left = Logout.Left;
            PnlNV.BackColor = Color.FromArgb(46, 51, 73);

            LoginFrm lgfm = new LoginFrm();
            this.Hide();
            lgfm.Show();

        }

        private void YourProfile_Leave(object sender, EventArgs e)
        {
            YourProfile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void EditProfile_Leave(object sender, EventArgs e)
        {
            EditProfile.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Calender_Leave(object sender, EventArgs e)
        {
            Calender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Home_Leave(object sender, EventArgs e)
        {
            Home.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Settings_Leave(object sender, EventArgs e)
        {
            Settings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Logout_Leave(object sender, EventArgs e)
        {
            Logout.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoliceDispatcher pds = new PoliceDispatcher();
            this.Hide();
            pds.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FireDispatcher fds = new FireDispatcher();
            this.Hide();
            fds.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmbulanceDispatcher abds = new AmbulanceDispatcher();
            this.Hide();
            abds.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           E_passport eps = new E_passport();
            this.Hide();
            eps.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Desco dsco = new Desco();
            this.Hide();
            dsco.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            W_and_C_helpline wch = new W_and_C_helpline();
            this.Hide();
            wch.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            covid_19Services cvdn = new covid_19Services();
            this.Hide();
            cvdn.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lob_Click(object sender, EventArgs e)
        {
            lob.Text = "Hi," + global.uname;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EducationBoard edb = new EducationBoard();
            this.Hide();
            edb.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Gray;
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GovtServices gt = new GovtServices();
            this.Hide();
            gt.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
