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
    public class RequestTypeManager : IRequestTypeService
    {
        IRequestTypeDal _requestTypeDal;
        public RequestTypeManager(IRequestTypeDal requestTypeDal)
        {
            _requestTypeDal = requestTypeDal;
        }

        public IResult Add(RequestType requestType)
        {
            _requestTypeDal.Add(requestType);
            return new SuccessResult(Messages.RequestTypeAdded);
        }

        public IDataResult<List<RequestType>> GetAll()
        {
            return new SuccessDataResult<List<RequestType>>(_requestTypeDal.GetAll(), Messages.RequestTypesListed);
        }

        public RequestType GetById(int requestTypeid)
        {
            return _requestTypeDal.Get(t => t.Id == requestTypeid);
        }
    }
}
