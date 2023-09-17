using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CompanyDetailDto:IDto
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string RequestType { get; set; }
        public int Rating { get; set; }
        //public string CompanyImage { get; set; }
        public string VehicleType { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}
