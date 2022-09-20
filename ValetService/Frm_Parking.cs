using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValetService.BI;
using System.Windows.Forms;

namespace ValetService
{    
    public partial class Frm_Parking : Form
    {
        
        Parking pk=new Parking();
        bool firsttime = false;
        public Frm_Parking()
        {
            InitializeComponent();
            pk.GetParkingLot(comboBox1_ParkingLot);
            checkFirstTimeParkingLot();

        }
        private void Reset()
        {
            if(!firsttime)
                comboBox1_ParkingLot.SelectedIndex=0;
            textBox1_ParkingSpot.Text=String.Empty;
            radioButton1_ParkingLot.Checked=false;
            radioButton2_ParkingSpot.Checked=false;
            comboBox1_ParkingLot.Enabled = true;
            radioButton2_ParkingSpot.Enabled = true;
            button2_Deactivate.Enabled = true;
            button3_Remove.Enabled = true;
            firsttime = false;

        }
        private void checkFirstTimeParkingLot()
        {
            if(comboBox1_ParkingLot.Items.Count > 1)
            {
                textBox1_ParkingSpot.Focus();
                comboBox1_ParkingLot.SelectedIndex = 0;
                firsttime = false;
            }
            else
            {
                comboBox1_ParkingLot.Enabled = false;
                radioButton2_ParkingSpot.Enabled = false;
                button2_Deactivate.Enabled = false;
                button3_Remove.Enabled = false;
                radioButton1_ParkingLot.Checked = true;
                firsttime = true;
                textBox1_ParkingSpot.Focus();
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_ParkingLot_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1_ParkingLot.Checked)
            {
                comboBox1_ParkingLot.Enabled = false;
                textBox1_ParkingSpot.Focus();
            }
            
        }

        private void radioButton2_ParkingSpot_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2_ParkingSpot.Checked)
            {
                comboBox1_ParkingLot.Enabled = true;
                textBox1_ParkingSpot.Focus();
            }
        }

        private void button1_Add_Click(object sender, EventArgs e)
        {
            bool validate = false;
            if((comboBox1_ParkingLot.SelectedIndex==0 || textBox1_ParkingSpot.Text=="") && firsttime==false)
            {
                MessageBox.Show("Enter Valid Info", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                validate = true;
            }
            if(validate)
            {
                pk.ParkingLot=firsttime?textBox1_ParkingSpot.Text:comboBox1_ParkingLot.SelectedValue.ToString();
                pk.ParkingSpot = firsttime ? String.Empty : textBox1_ParkingSpot.Text;

                int result=pk.InsertOrUpdateParking(pk);
                if(result==1)
                {
                    MessageBox.Show("Record saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Error occured while saving the record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pk.GetParkingLot(comboBox1_ParkingLot);
            }
        }

        private void button2_Deactivate_Click(object sender, EventArgs e)
        {
            bool validate = false;
            if ((comboBox1_ParkingLot.SelectedIndex == 0 || textBox1_ParkingSpot.Text == "") && firsttime == false)
            {
                MessageBox.Show("Enter Valid Info", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                if(radioButton1_ParkingLot.Checked)
                {
                    pk.ParkingLot = comboBox1_ParkingLot.SelectedValue.ToString();
                }
                if(radioButton2_ParkingSpot.Checked)
                {
                    pk.ParkingLot = comboBox1_ParkingLot.SelectedValue.ToString();
                    pk.ParkingSpot = textBox1_ParkingSpot.Text;
                }
                

                int result = pk.DeactivateParking(pk);
                if (result == 1)
                {
                    MessageBox.Show("Record deactivated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Error occured while deactivating the record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pk.GetParkingLot(comboBox1_ParkingLot);
            }
        }

        private void button3_Remove_Click(object sender, EventArgs e)
        {
            bool validate = false;
            if ((comboBox1_ParkingLot.SelectedIndex == 0 || textBox1_ParkingSpot.Text == "") && firsttime == false)
            {
                MessageBox.Show("Enter Valid Info", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                if (radioButton1_ParkingLot.Checked)
                {
                    pk.ParkingLot = comboBox1_ParkingLot.SelectedValue.ToString();
                }
                if (radioButton2_ParkingSpot.Checked)
                {
                    pk.ParkingLot = comboBox1_ParkingLot.SelectedValue.ToString();
                    pk.ParkingSpot = textBox1_ParkingSpot.Text;
                }


                int result = pk.DeleteParking(pk);
                if (result == 1)
                {
                    MessageBox.Show("Record deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Error occured while deleting the record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pk.GetParkingLot(comboBox1_ParkingLot);
            }
        }

        private void comboBox1_ParkingLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!radioButton2_ParkingSpot.Checked)
                radioButton2_ParkingSpot.Checked = true;
        }
    }
}
