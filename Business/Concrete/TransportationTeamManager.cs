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
    public class TransportationTeamManager : ITransportationTeamService
    {
        ITransportationTeamDal _transportationTeamDal;
        public TransportationTeamManager(ITransportationTeamDal transportationTeamDal)
        {
            _transportationTeamDal = transportationTeamDal;
        }
        public List<TransportationTeam> GetAll()
        {
            return _transportationTeamDal.GetAll();
        }
    }
}
