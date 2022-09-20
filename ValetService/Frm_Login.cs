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
    public partial class Frm_Login : Form
    {
        User user=new User();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validate = false;
            if((rbAdmin.Checked || rbEmployee.Checked) && tbUsername.Text!="" && tbPassword.Text!="")
            {
                validate = true;
            }
            if (validate)
            {
                bool role=rbAdmin.Checked? rbAdmin.Checked :(!rbEmployee.Checked);
                if (user.checkLogin(tbUsername.Text, tbPassword.Text, role))
                {
                    if(User.userType)
                    {
                        //Admin Home
                        Frm_AdminHome frm_AdminHome = new Frm_AdminHome();
                        frm_AdminHome.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //Employee Home
                        Frm_EmployeeHome frm_EmployeeHome = new Frm_EmployeeHome();
                        frm_EmployeeHome.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter valid credentials", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
