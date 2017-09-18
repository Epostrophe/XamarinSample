using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Models
{
    class vehicle
    {
        public int ID { get; set; }
        public string model { get; set; }
        public string Make { get; set; }

        public void LoadVehicleData(string vehicleID)
        {
            throw new NotImplementedException();
        }
    }
}
