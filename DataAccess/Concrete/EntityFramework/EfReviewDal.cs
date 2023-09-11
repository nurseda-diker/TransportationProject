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
    public class EfReviewDal : IReviewDal
    {
        public void Add(Review entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Review entity)
        {
            throw new NotImplementedException();
        }

        public Review Get(Expression<Func<Review, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetAll(Expression<Func<Review, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
