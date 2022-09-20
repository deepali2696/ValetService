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
    public partial class Frm_AdminHome : Form
    {
        User user=new User();
        public Frm_AdminHome()
        {
            InitializeComponent();
            lblUsername.Text = User.username;
        }
        

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Login Form
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.ShowDialog();
            this.Close();
        }

        private void btnEmployeeAccess_Click(object sender, EventArgs e)
        {
            Frm_Employee_Access frm_Employee_Access= new Frm_Employee_Access();
            frm_Employee_Access.ShowDialog();
            this.Close();
        }

        private void btnParkingAccess_Click(object sender, EventArgs e)
        {
            Frm_Parking frm_Parking= new Frm_Parking(); 
            frm_Parking.ShowDialog();   
            this.Close();
        }
    }
}
