using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Review:IEntity
    {
        public int ReviewId { get; set; }
        public int UserId { get; set; }
        public int ReservationId { get; set; }
        public string Commit { get; set; }
        public int Rating { get; set; }
    }
}
