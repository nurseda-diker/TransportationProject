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
    public class RequestTypeManager : IRequestTypeService
    {
        IRequestTypeDal _requestTypeDal;
        public RequestTypeManager(IRequestTypeDal requestTypeDal)
        {
            _requestTypeDal = requestTypeDal;
        }

        public List<RequestType> GetAll()
        {
            return _requestTypeDal.GetAll();
        }

        public RequestType GetById(int requestTypeid)
        {
            return _requestTypeDal.Get(t => t.Id == requestTypeid);
        }
    }
}
