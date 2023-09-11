using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTransportRequestDal : ITransportRequestDal
    {
        public void Add(TransportRequest entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TransportRequest entity)
        {
            throw new NotImplementedException();
        }

        public TransportRequest Get(Expression<Func<TransportRequest, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TransportRequest> GetAll(Expression<Func<TransportRequest, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TransportRequest entity)
        {
            throw new NotImplementedException();
        }
    }
}
