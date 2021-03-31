using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    class VehicleIn
    {
        private string tokenNo;

        public string TokenNO
        {
            get { return tokenNo; }
            set { tokenNo = value; }
        }

        private string vehicleNO;

        public string VehicleNO
        {
            get { return vehicleNO; }
            set { vehicleNO = value; }
        }
        private int brand;

        public int Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        private int color;

        public int Color
        {
            get { return color; }
            set { color = value; }
        }
        private int timeIn;

        public int TimeIn
        {
            get { return timeIn; }
            set { timeIn = value; }
        }
    }
}
