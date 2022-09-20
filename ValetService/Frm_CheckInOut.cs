using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ValetService
{
    public partial class Frm_CheckInOut : Form
    {
        public Frm_CheckInOut()
        {
            InitializeComponent();
            showdata();
        }
        private void showdata()
        {  
            ListViewItem listitem = new ListViewItem();
            listitem.SubItems.Add("12346");
            listitem.SubItems.Add("Yes");
            listitem.SubItems.Add("102");
            listitem.SubItems.Add("Nissan");
            listitem.SubItems.Add("ABC 123");
            listitem.SubItems.Add("Auto");
            listitem.SubItems.Add("P1");
            listitem.SubItems.Add("PS1");
            listitem.SubItems.Add("True");
            listitem.SubItems.Add("False");

            listView1.Items.Add(listitem);
        }
        private void tbCheckInId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            tbCheckInId.Text =String.Empty;
            tbRoomNo.Text =String.Empty;
            tbCarModel.Text =String.Empty;  
            tbCarPlateNo.Text =String.Empty;
            cbParkingLot.SelectedIndex =0;
            cbParkingSpot.SelectedIndex =0;
            rbYes.Checked = false;  
            rbNo.Checked = false;   
            rbAuto.Checked = false;
            rbManual.Checked = false;

        }
    }
}
