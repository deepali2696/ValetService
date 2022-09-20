using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValetService.GUI
{
    public class Car { 
        private int CheckIn_Id { get; set; }

        private int Slip_Id { get; set; }
        private int Room_No { get; set; }
        private string Model { get; set; }
        private string PrakingLot { get; set; }
        private string Parking_Spot { get; set; }
        private DateTime CheckOutDate { get; set; }
        private Boolean Car_In { get; set; }
        private Boolean Car_Out { get; set; }

    }
}
