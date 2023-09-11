using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Vehicle:IEntity
    {
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleType { get; set; }
        public string VehicleCapacity { get; set; }
    }
}
