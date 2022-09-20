using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValetService.DBContext;

namespace ValetService.BI
{
    public class Parking
    {
        DBLayer db=new DBLayer();
        public int ParkingId { get; set; }

        public string ParkingLot { get; set; }

        public string ParkingSpot { get; set; }

        public string status { get; set; }

        public int InsertOrUpdateParking(Parking obj)
        {
            
            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@ActionType","SaveData"),
                new SqlParameter("@ParkingLot",obj.ParkingLot),
                new SqlParameter("@ParkingSpot",obj.ParkingSpot)
            };
            try
            {
                int result = db.spForDataInsertOrUpdate("spParking", sp);
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int DeactivateParking(Parking obj)
        {

            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@ActionType","DeactivateData"),
                new SqlParameter("@ParkingLot",obj.ParkingLot),
                new SqlParameter("@ParkingSpot",obj.ParkingSpot)
            };
            try
            {
                int result = db.spForDataInsertOrUpdate("spParking", sp);
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int DeleteParking(Parking obj)
        {

            SqlParameter[] sp = new SqlParameter[] {
                new SqlParameter("@ActionType","DeleteData"),
                new SqlParameter("@ParkingLot",obj.ParkingLot),
                new SqlParameter("@ParkingSpot",obj.ParkingSpot)
            };
            try
            {
                int result = db.spForDataInsertOrUpdate("spParking", sp);
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public DataTable ListAllParkingLocation()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = db.spForSelectData("spParking", "FetchAllData");
                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        

        public void GetParkingLot(ComboBox cb)
        {
            DataTable dt = new DataTable();
            
            dt = db.spForSelectData("spParking", "ListParkingLot");
            if(dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.NewRow();
                dr[0] = 0;
                dr[1] = "-- Please Select --";
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = "Lot";
                cb.ValueMember = "Lot";
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr[0] = 0;
                dr[1] = "-- Please Select --";
                dt.Rows.InsertAt(dr, 0);
            }

        }
    }
}
