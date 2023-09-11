using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TransportRequestManager : ITransportRequestService
    {
        ITransportRequestDal _transportRequestDal;

        public TransportRequestManager(ITransportRequestDal transportRequestDal)
        {
            _transportRequestDal = transportRequestDal;
        }
        public List<TransportRequest> GetAll()
        {
            return _transportRequestDal.GetAll();
        }

        public List<TransportRequest> GetByRequestPrice(decimal min, decimal max)
        {
            return _transportRequestDal.GetAll(t => t.RequestPrice <= min && t.RequestPrice <= max);
        }
    }
}
