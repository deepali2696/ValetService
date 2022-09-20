using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ValetService.BI;
using ValetService.DBContext;

namespace ValetService
{
    public partial class Frm_Employee_Access : Form
    {

        SqlConnection conn = new SqlConnection(DBLayer.connString);
        EmployeeAccess emp = new EmployeeAccess();

        public Frm_Employee_Access()
        {
            InitializeComponent();
        }

        private void AdminInsertMode()
        {
            textBox2_username.Focus();
            textBox1_EmployeeName.Enabled = false;
            textBox2_Contact_info.Enabled = false;
            textBox2_Education.Enabled = false;
            textBox2_Designation.Enabled = false;
            textBox3_Availability.Enabled = false;
            comboBox1_WorkStatus.Enabled = false;
        }
        private void EmployeeInsertMode()
        {
            textBox1_EmployeeName.Focus();
            textBox1_EmployeeName.Enabled = true;
            textBox2_Contact_info.Enabled = true;
            textBox2_Education.Enabled = true;
            textBox2_Designation.Enabled = true;
            textBox3_Availability.Enabled = true;
            comboBox1_WorkStatus.Enabled = true;
        }
        private void showdata()
        {

            DataTable dt = new DataTable();
            dt = emp.fetchAllEmployee();
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["EmployeeId"].ToString());
                    listitem.SubItems.Add(dr["UserId"].ToString());
                    listitem.SubItems.Add(dr["UserName"].ToString());
                    listitem.SubItems.Add(dr["Password"].ToString());
                    listitem.SubItems.Add(Convert.ToBoolean(dr["Role"].ToString()) ? "Admin" : "Employee");
                    listitem.SubItems.Add(dr["EmployeeName"].ToString());
                    listitem.SubItems.Add(dr["ContactInfo"].ToString());
                    listitem.SubItems.Add(dr["Education"].ToString());
                    listitem.SubItems.Add(dr["Designation"].ToString());
                    listitem.SubItems.Add(dr["Availability"].ToString());
                    listitem.SubItems.Add(dr["WorkStatus"].ToString());

                    listView1.Items.Add(listitem);
                }
            }
        }
        private void Clearall()
        {
            textBox1_EmployeeID.Clear();
            textBox2_username.Clear();
            textBox1_Password.Clear();
            textBox1_UserID.Clear();
            textBox1_EmployeeName.Clear();
            textBox2_Contact_info.Clear();
            textBox2_Education.Clear();
            textBox3_Availability.Clear();
            comboBox1_WorkStatus.SelectedIndex = 0;
            rbAdmin.Checked = false;
            rbEmployee.Checked = true;
        }
        private bool Validate()
        {
            bool valid = true;
            if ((!rbAdmin.Checked) && (!rbEmployee.Checked)) { valid = false; }
            if (textBox2_username.Text == "") { valid = false; }
            if (string.IsNullOrEmpty(textBox1_Password.Text)) { valid = false; }
            if (string.IsNullOrEmpty(textBox1_EmployeeName.Text)) { valid = false; }
            if (string.IsNullOrEmpty(textBox2_Education.Text)) { valid = false; }
            if (string.IsNullOrEmpty(textBox3_Availability.Text)) { valid = false; }
            if (comboBox1_WorkStatus.SelectedIndex == 0) { valid = false; }
            if (string.IsNullOrEmpty(textBox1_EmployeeID.Text)) { valid = false; }
            if (!int.TryParse(textBox1_EmployeeID.Text, out int n)) { valid = false; }
            if (string.IsNullOrEmpty(textBox1_UserID.Text)) { valid = false; }
            if (!int.TryParse(textBox1_UserID.Text, out int o)) { valid = false; }
            if (string.IsNullOrEmpty(textBox2_Contact_info.Text)) { valid = false; }
            if (!int.TryParse(textBox2_Contact_info.Text, out int p)) { valid = false; }
            return valid;

        }
        private bool editValidate()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(textBox1_EmployeeID.Text)) { textBox1_EmployeeID.Text = 0.ToString(); }
            if (!int.TryParse(textBox1_EmployeeID.Text, out int n)) { valid = false; }
            if (string.IsNullOrEmpty(textBox1_UserID.Text)) { textBox1_UserID.Text = 0.ToString(); }
            if (!int.TryParse(textBox1_UserID.Text, out int o)) { valid = false; }
            return valid;
        }
        private void button1_Add_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                string role = "";
                if (rbAdmin.Checked)
                {
                    emp.UserId = 0;
                    emp.uname = textBox2_username.Text;
                    emp.pwd = textBox1_Password.Text;
                    role = "Admin";
                }
                else
                {
                    emp.UserId = 0;
                    emp.uname = textBox2_username.Text;
                    emp.pwd = textBox1_Password.Text;
                    emp.role = rbAdmin.Checked ? rbAdmin.Checked : (!rbEmployee.Checked);
                    emp.EmployeeName = textBox1_EmployeeName.Text;
                    emp.ContactInfo = textBox2_Contact_info.Text;
                    emp.Availability = textBox3_Availability.Text;
                    emp.Designation = textBox2_Designation.Text;
                    emp.Education = textBox2_Education.Text;
                    emp.WorkStatus = comboBox1_WorkStatus.SelectedItem.ToString();
                    role = "Employee";

                }
                int result = emp.EmployeeAddOrUpdate(emp, role);
                if (result > 0)
                {
                    MessageBox.Show("Data Inserted Successfully.", "Confirmed");
                    Clearall();
                }
                else
                {
                    MessageBox.Show("Error during record insert.", "Error");
                }
                //Query to insert data in the database on click event of Add button
                //SqlCommand cmd = new SqlCommand("insert into Employee (UserId,EmployeeName,ContactInfo,Education,Designation,Availability,WorkStatus,CreatedDate,UpdatedDate,IsActive,IsDelete) values ('" + textBox1_UserID.Text + "', '" + textBox1_EmployeeName.Text + "' , '" + textBox2_Contact_info.Text + "' , '" + textBox2_Education.Text + "' , '" + textBox2_Designation.Text + "' , '" + textBox3_Availability.Text + "' , '" + comboBox1_WorkStatus.SelectedItem + "' , '" + DateTime.Now.ToString() + "' , '" + DateTime.Now.ToString() + "' , 1,0)", conn);

                showdata();
                textBox1_UserID.Focus();
            }
            else
            {
                MessageBox.Show("Please enter all Information as per the required field", "Validation Error");
            }
        }

        private void button1_Edit_Click(object sender, EventArgs e)
        {
            if (editValidate())
            {
                string role = "";
                if (rbAdmin.Checked)
                {
                    emp.UserId = Convert.ToInt32(textBox1_UserID.Text);
                    emp.uname = textBox2_username.Text;
                    emp.pwd = textBox1_Password.Text;
                    role = "Admin";
                }
                else
                {
                    emp.UserId = Convert.ToInt32(textBox1_UserID.Text);
                    emp.EmployeeId = Convert.ToInt32(textBox1_EmployeeID.Text);
                    role = "Employee";

                }
                DataTable dt = emp.fetchEditData(emp, role);
                if (dt!=null && dt.Rows.Count>0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];

                        textBox1_UserID.Text=dr["UserId"].ToString();
                        textBox2_username.Text=dr["UserName"].ToString();
                        textBox1_Password.Text=dr["Password"].ToString();
                        rbAdmin.Checked=Convert.ToBoolean(dr["Role"].ToString());
                        rbEmployee.Checked = (!Convert.ToBoolean(dr["Role"].ToString()));
                        textBox1_EmployeeName.Text=dr["EmployeeName"].ToString();
                        textBox2_Contact_info.Text=dr["ContactInfo"].ToString();
                        textBox2_Education.Text=dr["Education"].ToString();
                        textBox2_Designation.Text= dr["Designation"].ToString();
                        textBox3_Availability.Text=dr["Availability"].ToString();
                        comboBox1_WorkStatus.SelectedIndex=dr["WorkStatus"].ToString().Equals("Part-Time")?1:2;
                    }
                }
                else
                {
                    MessageBox.Show("Unable to retrive record .", "Error");
                }
                showdata();
                textBox1_UserID.Focus();
            }
            else
            {
                MessageBox.Show("Please enter all Information as per the required field", "Validation Error");
            }
        }


        
        private void Frm_Employee_Access_Load(object sender, EventArgs e)
        {
            textBox1_EmployeeID.Text = 00.ToString();
            textBox1_UserID.Text = 00.ToString();
            rbEmployee.Checked = true;
            showdata();
        }


        private void button2_Deactivate_Click(object sender, EventArgs e)
        {
            if (editValidate())
            {
                string role = "";
                if (rbAdmin.Checked)
                {
                    emp.UserId = Convert.ToInt32(textBox1_UserID.Text);
                    emp.uname = textBox2_username.Text;
                    emp.pwd = textBox1_Password.Text;
                    role = "Admin";
                }
                else
                {
                    emp.UserId = Convert.ToInt32(textBox1_UserID.Text);
                    emp.EmployeeId = Convert.ToInt32(textBox1_EmployeeID.Text);
                    role = "Employee";
                }
                int result = emp.EmployeeAddOrUpdate(emp, role);
                if (result > 0)
                {
                    MessageBox.Show("Data Inserted Successfully.", "Confirmed");
                    Clearall();
                }
                else
                {
                    MessageBox.Show("Error during record insert.", "Error");
                }
                //Query to insert data in the database on click event of Add button
                //SqlCommand cmd = new SqlCommand("insert into Employee (UserId,EmployeeName,ContactInfo,Education,Designation,Availability,WorkStatus,CreatedDate,UpdatedDate,IsActive,IsDelete) values ('" + textBox1_UserID.Text + "', '" + textBox1_EmployeeName.Text + "' , '" + textBox2_Contact_info.Text + "' , '" + textBox2_Education.Text + "' , '" + textBox2_Designation.Text + "' , '" + textBox3_Availability.Text + "' , '" + comboBox1_WorkStatus.SelectedItem + "' , '" + DateTime.Now.ToString() + "' , '" + DateTime.Now.ToString() + "' , 1,0)", conn);

                showdata();
                textBox1_UserID.Focus();
            }
            else
            {
                MessageBox.Show("Please enter all Information as per the required field", "Validation Error");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AdminInsertMode();
        }



        private void rbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeInsertMode();
        }

        private void button1_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_AdminHome frm = new Frm_AdminHome();
            frm.ShowDialog();
        }
    }
}
