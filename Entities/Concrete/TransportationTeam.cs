using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TransportationTeam:IEntity
    {
        public int TransportationTeamId { get; set; }
        public string TeamName { get; set; }
        public List<string> TeamMembers { get; set; }
        public string TeamLeader { get; set; }
        public string ContactEmail { get; set; } 
        public string ContactPhone { get; set; } 
    }
}
