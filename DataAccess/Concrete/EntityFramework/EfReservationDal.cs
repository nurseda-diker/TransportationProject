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
    public class EfReservationDal : IReservationDal
    {
        public void Add(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation Get(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAll(Expression<Func<Reservation, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
