using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Report.GUI;

namespace Report
{
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SK3FPLU\\SQLEXPRESS;Initial Catalog=ValetService;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        DataSet ds;
        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Report_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxCategory.SelectedIndex;
            switch (choice)
            {
                case 0:
                  comboBoxCategory.SelectedIndex = 0;
                    buttonSearch.Focus();
                    break;
                case 1:
                    comboBoxCategory.SelectedIndex = 1;
                    buttonSearch.Focus();
                    break;
                case 2:
                    comboBoxCategory.SelectedIndex = 2;
                    buttonSearch.Focus();
                    break;
                default:
                    MessageBox.Show("Please select the category,Error");
                    break;

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (comboBoxCategory.SelectedIndex == 0)
            {
                cmd = new SqlCommand("select * from CheckInOut", conn);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "testTable");
                conn.Close();

                dt = ds.Tables["testTable"];
                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listViewReport.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[14].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[15].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[12].ToString());
                }


            }
            else if (comboBoxCategory.SelectedIndex == 1)
            {
                cmd = new SqlCommand("select * from CheckInOut", conn);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "testTable");
                conn.Close();

                dt = ds.Tables["testTable"];
                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listViewReport.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[14].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[15].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[13].ToString());
                }
            }
            else if (comboBoxCategory.SelectedIndex == 2)
            {
                cmd = new SqlCommand("select * from CheckInOut", conn);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "testTable");
                conn.Close();

                dt = ds.Tables["testTable"];
                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listViewReport.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[14].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[15].ToString());
                    listViewReport.Items[i].SubItems.Add(dt.Rows[i].ItemArray[13].ToString());
                }
            }
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
