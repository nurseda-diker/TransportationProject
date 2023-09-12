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
    public class DriverManager:IDriverService
    {
        IDriverDal _driverDal;

        public DriverManager(IDriverDal driverDal)
        {
            _driverDal = driverDal;
        }

        public IResult Add(Driver driver)
        {
            _driverDal.Add(driver);
            return new SuccessResult(Messages.DriverAdded);
        }

        public IDataResult<List<Driver>> GetAll()
        {
            return new SuccessDataResult<List<Driver>>(_driverDal.GetAll(), Messages.DriversListed);
        }
    }
}
