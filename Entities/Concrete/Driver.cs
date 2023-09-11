using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Driver:IEntity
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
