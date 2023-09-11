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
    public class EfTransportationTeamDal : ITransportationTeamDal
    {
        public void Add(TransportationTeam entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TransportationTeam entity)
        {
            throw new NotImplementedException();
        }

        public TransportationTeam Get(Expression<Func<TransportationTeam, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TransportationTeam> GetAll(Expression<Func<TransportationTeam, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TransportationTeam entity)
        {
            throw new NotImplementedException();
        }
    }
}
