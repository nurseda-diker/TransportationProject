using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(TransportRequest transportRequest)
        {
            _transportRequestDal.Add(transportRequest);
            return new SuccessResult(Messages.TransportRequestAdded);
        }

        public IDataResult<List<TransportRequest>> GetAll()
        {
            return new SuccessDataResult<List<TransportRequest>>(_transportRequestDal.GetAll(),Messages.TransportRequestsListed);
        }

        //public List<TransportRequest> GetByRequestPrice(decimal min, decimal max)
        //{
        //    return _transportRequestDal.GetAll(t => t.RequestPrice <= min && t.RequestPrice <= max);
        //}

        //IDataResult<List<TransportRequest>> ITransportRequestService.GetByRequestPrice(decimal min, decimal max)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
