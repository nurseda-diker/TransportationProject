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
    public class EfDriverDal : IDriverDal
    {
        public void Add(Driver entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Driver entity)
        {
            throw new NotImplementedException();
        }

        public Driver Get(Expression<Func<Driver, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Driver> GetAll(Expression<Func<Driver, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Driver entity)
        {
            throw new NotImplementedException();
        }
    }
}
