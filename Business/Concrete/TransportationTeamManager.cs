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
    public class TransportationTeamManager : ITransportationTeamService
    {
        ITransportationTeamDal _transportationTeamDal;
        public TransportationTeamManager(ITransportationTeamDal transportationTeamDal)
        {
            _transportationTeamDal = transportationTeamDal;
        }

        public IResult Add(TransportationTeam transportationTeam)
        {
            _transportationTeamDal.Add(transportationTeam);
            return new SuccessResult(Messages.TransportationTeamAdded);
        }

        public IDataResult<List<TransportationTeam>> GetAll()
        {
            return new SuccessDataResult<List<TransportationTeam>>(_transportationTeamDal.GetAll(), Messages.TransportationTeamsListed);
        }

        public IDataResult<List<TransportationTeam>> GetTeamByCompanyId(int companyId)
        {
            return new SuccessDataResult<List<TransportationTeam>>(_transportationTeamDal.GetAll(t => t.CompanyId == companyId));
        }
    }
}
