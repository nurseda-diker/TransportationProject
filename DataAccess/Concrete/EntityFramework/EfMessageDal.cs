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
    public class EfMessageDal : IMessageDal
    {
        public void Add(Message entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message entity)
        {
            throw new NotImplementedException();
        }

        public Message Get(Expression<Func<Message, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetAll(Expression<Func<Message, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
