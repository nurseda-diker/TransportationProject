using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TransportRequest:IEntity
    {
        public int TransportRequestId { get; set; }
        public int UserId { get; set; }
        public int RequestTypeId { get; set; }
        public decimal RequestPrice { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        public DateTime RequestDate { get; set; }
        public bool Status { get; set; }
    }
}
