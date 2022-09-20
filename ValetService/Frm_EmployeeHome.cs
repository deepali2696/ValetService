using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValetService.BI;

namespace ValetService
{
    public partial class Frm_EmployeeHome : Form
    {
        public Frm_EmployeeHome()
        {
            InitializeComponent();
            lblUsername.Text = User.username;
        }

        private void btnCheckInOut_Click(object sender, EventArgs e)
        {
            //form CheckInOut
            Frm_CheckInOut frm_CheckInOut = new Frm_CheckInOut();
            frm_CheckInOut.ShowDialog();
            this.Close();
        }

        private void btnCarInOut_Click(object sender, EventArgs e)
        {
            //form CarInOut
            Frm_CarInOut carInOut=new Frm_CarInOut();
            carInOut.ShowDialog();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Form Report
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Login Form
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            this.Close();
        }
    }
}
