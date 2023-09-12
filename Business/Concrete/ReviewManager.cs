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
    public class ReviewManager:IReviewService
    {
        IReviewDal _reviewDal;
        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }

        public IResult Add(Review review)
        {
            _reviewDal.Add(review);
            return new SuccessResult(Messages.ReviewAdded);
        }

        public IDataResult<List<Review>> GetAll()
        {
            return new SuccessDataResult<List<Review>>(_reviewDal.GetAll(),Messages.ReviewsListed);
        }
    }
}
