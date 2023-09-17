using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal : EfEntitiyRepositoryBase<Company, TransportationContext>, ICompanyDal
    {

        public List<CompanyDetailDto> GetCompanyDetails()
        {
            using (TransportationContext context = new TransportationContext())
            {
                var result = from company in context.Companies
                             join requestType in context.RequestTypes on company.RequestTypeId equals requestType.RequestTypeId
                             join rating in context.Reviews on company.ReviewId equals rating.ReviewId
                             join vehicle in context.Vehicles on company.VehicleId equals vehicle.VehicleId
                             select new CompanyDetailDto
                             {
                                 CompanyId = company.CompanyId,
                                 CompanyName = company.CompanyName,
                                 RequestType = requestType.RequestTypeName,
                                 Rating = rating.Rating,
                                 VehicleType = vehicle.VehicleType,
                                 PhoneNumber = company.PhoneNumber,
                                 Address = company.Address,
                                 Email = company.Email

                             };
                return result.ToList();

            }
        }

        public List<CompanyDetailDto> GetCompanyDetailsByCompanyId(int companyId)
        {
            using (TransportationContext context = new TransportationContext())
            {
                var result = from company in context.Companies
                             join requestType in context.RequestTypes on company.RequestTypeId equals requestType.RequestTypeId
                             join rating in context.Reviews on company.ReviewId equals rating.ReviewId
                             join vehicle in context.Vehicles on company.VehicleId equals vehicle.VehicleId
                             where companyId==company.CompanyId
                             select new CompanyDetailDto
                             {
                                 CompanyId = company.CompanyId,
                                 CompanyName = company.CompanyName,
                                 RequestType = requestType.RequestTypeName,
                                 Rating = rating.Rating,
                                 VehicleType = vehicle.VehicleType,
                                 PhoneNumber = company.PhoneNumber,
                                 Address = company.Address,
                                 Email = company.Email

                             };
                return result.ToList();

            }
        }

        public List<CompanyDetailDto> GetCompanyDetailsByRequestId(int requestId)
        {
            using (TransportationContext context = new TransportationContext())
            {
                var result = from company in context.Companies
                             join requestType in context.RequestTypes on company.RequestTypeId equals requestType.RequestTypeId
                             join rating in context.Reviews on company.ReviewId equals rating.ReviewId
                             join vehicle in context.Vehicles on company.VehicleId equals vehicle.VehicleId
                             where requestId == requestType.RequestTypeId
                             select new CompanyDetailDto
                             {
                                 CompanyId = company.CompanyId,
                                 CompanyName = company.CompanyName,
                                 RequestType = requestType.RequestTypeName,
                                 Rating = rating.Rating,
                                 VehicleType = vehicle.VehicleType,
                                 PhoneNumber = company.PhoneNumber,
                                 Address = company.Address,
                                 Email = company.Email

                             };
                return result.ToList();

            }
        }

       
    }
}



       
