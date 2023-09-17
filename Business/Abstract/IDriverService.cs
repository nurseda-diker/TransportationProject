using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDriverService
    {
        IDataResult<List<Driver>> GetAll();
        IResult Add(Driver driver);

        IDataResult<List<Driver>> GetDriversByVehicleId(int vehicleId);

    }
}
