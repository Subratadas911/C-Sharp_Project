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
    public partial class AdminServerMonitor : Form
    {
        public AdminServerMonitor()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Dashbord dbsg = new Dashbord();
            this.Hide();
            dbsg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAllUser updateAllUser = new UpdateAllUser();
            this.Hide();
            updateAllUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewLoginDetails viewLoginDetails = new ViewLoginDetails();
            this.Hide();
            viewLoginDetails.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPoliceDispatcher policeDispatcher = new AdminPoliceDispatcher();
            this.Hide();
            policeDispatcher.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminFireDispatcher fireDispatcher = new AdminFireDispatcher();
            this.Hide();
            fireDispatcher.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminAmbulanceDispatcher adminAmbulanceDispatcher = new AdminAmbulanceDispatcher();
            this.Hide();
                adminAmbulanceDispatcher.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminCovidService adminCovidService = new AdminCovidService();  
            this.Hide();
            adminCovidService.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminDesco adminDesco = new AdminDesco();
            this.Hide();
            adminDesco.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminE_Passport adminE_Passport = new AdminE_Passport();
            this.Hide();
            adminE_Passport.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminEducationBoard adminEducationBoard = new AdminEducationBoard();
            this.Hide();
            adminEducationBoard.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdminWomenChildHelp adminWomenChildHelp = new AdminWomenChildHelp();
            this.Hide();
            adminWomenChildHelp.Show();
        }
    }
}
