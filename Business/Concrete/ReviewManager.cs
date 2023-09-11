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
    public class ReviewManager:IReviewService
    {
        IReviewDal _reviewDal;
        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }

        public List<Review> GetAll()
        {
            return _reviewDal.GetAll();
        }
    }
}
