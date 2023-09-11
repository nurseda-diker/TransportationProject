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
    public class DriverManager:IDriverService
    {
        IDriverDal _driverDal;

        public DriverManager(IDriverDal driverDal)
        {
            _driverDal = driverDal;
        }

        public List<Driver> GetAll()
        {
            return _driverDal.GetAll();
        }
    }
}
