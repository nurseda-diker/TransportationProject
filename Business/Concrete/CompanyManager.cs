using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(Messages.CompanyAdded);
        }

        public IDataResult<List<Company>> GetAll()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(),Messages.CompaniesListed);
        }

        public IDataResult<List<CompanyDetailDto>> GetById(int companyId)
        {
            return new SuccessDataResult<List<CompanyDetailDto>>(_companyDal.GetCompanyDetailsByCompanyId(companyId));
        }

        public IDataResult<List<CompanyDetailDto>> GetCompanyDetails()
        {
            return new SuccessDataResult<List<CompanyDetailDto>>(_companyDal.GetCompanyDetails());
        }

        public IDataResult<List<CompanyDetailDto>> GetCompanyDetailsByRequestId(int requestId)
        {
            return new SuccessDataResult<List<CompanyDetailDto>>(_companyDal.GetCompanyDetailsByRequestId(requestId));
        }
    }
}
