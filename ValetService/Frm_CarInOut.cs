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
using ValetService.DBContext;

namespace ValetService
{
    public partial class Frm_CarInOut : Form
    {
        public Frm_CarInOut()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(DBLayer.connString);
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCarOut_Click(object sender, EventArgs e)
        {
            conn.Open();
            // cmd = new SqlCommand("INSERT INTO dbo.CarInOut(ParkingLot, ParkingSpot, CreatedDate, UpdatedDate, IsActive, IsDelete) SELECT ParkingLot, ParkingSpot, CreatedDate, UpdatedDate, IsActive, IsDelete from dbo.CheckInOut where SlipId = '" + textBoxDetails.Text + "' OR RoomNo = '" + textBoxDetails.Text + "'", conn);

           SqlCommand cmd1 = new SqlCommand("INSERT INTO CarInOut(ParkingLot, ParkingSpot, CreatedDate, UpdatedDate, IsActive, IsDelete) SELECT ParkingLot, ParkingSpot, CreatedDate, UpdatedDate, IsActive, IsDelete from CheckInOut where SlipId = '" + textBoxDetails.Text + "' OR RoomNo = '" + textBoxDetails.Text + "'", conn);
           cmd1.ExecuteNonQuery();
           MessageBox.Show("Car is temporary out now", "Successful");            
            conn.Close();

        }


        private void ComboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            int choice = ComboSearch.SelectedIndex;
            switch (choice)
            {
                case 0:
                    label3.Text = "Enter CheckIn Id";
                    textBoxDetails.Focus();
                    break;
                case 1:
                    label3.Text = "Enter Room No";
                    textBoxDetails.Focus();
                    break;
                default:
                    break;

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (ComboSearch.SelectedIndex == 0)
            {
                cmd = new SqlCommand("select * from CheckInOut where SlipId = '" + textBoxDetails.Text + "'", conn);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "testTable");
                conn.Close();

                dt = ds.Tables["testTable"];
                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listViewCarInOut.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[13].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    
                }
            }
            else if(ComboSearch.SelectedIndex==1)
            {
                cmd = new SqlCommand("select * from CheckInOut where RoomNo = '" + textBoxDetails.Text + "'", conn);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "testTable");
                conn.Close();

                dt = ds.Tables["testTable"];
                int i;
                for (i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    listViewCarInOut.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[13].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                   
                }
            }
            else
            {
                MessageBox.Show("Please select valid option");
            }

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("select * from CheckInOut", conn);
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds, "testTable");
            conn.Close();

            dt = ds.Tables["testTable"];
            int i;
            for (i = 0; i <= dt.Rows.Count -1 ; i++)
            {
                listViewCarInOut.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[8].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[9].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[10].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[13].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listViewCarInOut.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
              
            }



        }

        private void textBoxDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewCarInOut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCarIn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("INSERT INTO CarInOut(ParkingLot, ParkingSpot, CreatedDate, UpdatedDate, IsActive, IsDelete) SELECT ParkingLot, ParkingSpot, CreatedDate, UpdatedDate, IsActive, IsDelete from CheckInOut where SlipId = '" + textBoxDetails.Text + "' OR RoomNo = '" + textBoxDetails.Text + "'", conn);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Car is CheckedIn again", "Successful");
            conn.Close();
        }
    }
}
