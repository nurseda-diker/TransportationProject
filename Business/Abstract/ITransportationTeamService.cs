using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITransportationTeamService
    {
        IDataResult<List<TransportationTeam>> GetAll();
        IResult Add(TransportationTeam transportationTeam);

        IDataResult<List<TransportationTeam>> GetTeamByCompanyId(int companyId);
    }
}
