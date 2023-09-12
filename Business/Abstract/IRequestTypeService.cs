
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRequestTypeService
    {
        IDataResult<List<RequestType>> GetAll();
        IResult Add(RequestType requestType);
        RequestType GetById(int requestTypeid);
    }
}
