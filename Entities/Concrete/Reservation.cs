using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reservation:IEntity
    {
        public int ReservationId { get; set; }
        public int TransportRequestId { get; set; }
        public int CompanyId { get; set; }
        public int VehicleId { get; set; }
        public decimal TransportPrice { get; set; }
        public DateTime ReservationDate { get; set; }
        

    }
}
