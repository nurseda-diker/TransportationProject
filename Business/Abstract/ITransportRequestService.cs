using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransportRequestService
    {
        List<TransportRequest> GetAll();
        List<TransportRequest> GetByRequestPrice(decimal min,decimal max);
    }
}
