using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report.GUI
{
    public class Repo
    {
        public int CheckIn_Id { get; set; }
        public int Slip_Id { get; set; }
        public int Room_No { get; set; }
        public string Model { get; set; }
        public string Location { get; set; }
       
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }

        public string Employee_Name { get; set; }
        public System.DateTime CheckOutDate { get; set; }
        public Boolean Car_In { get; set; }
        public Boolean Car_Out { get; set; }
    }

}

