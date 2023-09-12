using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class RequestType:IEntity
    {
        public int Id { get; set; }
        public string RequestTypeName { get; set; }
        public decimal  RequestTypePrice { get; set; }
    }
}
