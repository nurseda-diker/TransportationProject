using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
        List<CompanyDetailDto> GetCompanyDetails();
        List<CompanyDetailDto> GetCompanyDetailsByRequestId(int requestId);
        List<CompanyDetailDto> GetCompanyDetailsByCompanyId(int companyId);
    }
}
