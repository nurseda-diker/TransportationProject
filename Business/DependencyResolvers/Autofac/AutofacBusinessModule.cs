using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<CompanyManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyDal>().As<ICompanyDal>().SingleInstance();

            builder.RegisterType<DriverManager>().As<IDriverService>().SingleInstance();
            builder.RegisterType<EfDriverDal>().As<IDriverDal>().SingleInstance();

            builder.RegisterType<MessageManager>().As<IMessageService>().SingleInstance();
            builder.RegisterType<EfMessageDal>().As<IMessageDal>().SingleInstance();

            builder.RegisterType<RequestTypeManager>().As<IRequestTypeService>().SingleInstance();
            builder.RegisterType<EfRequestTypeDal>().As<IRequestTypeDal>().SingleInstance();

            builder.RegisterType<ReservationManager>().As<IReservationService>().SingleInstance();
            builder.RegisterType<EfReservationDal>().As<IReservationDal>().SingleInstance();

            builder.RegisterType<ReviewManager>().As<IReviewService>().SingleInstance();
            builder.RegisterType<EfReviewDal>().As<IReviewDal>().SingleInstance();


            builder.RegisterType<TransportationTeamManager>().As<ITransportationTeamService>().SingleInstance();
            builder.RegisterType<EfTransportationTeamDal>().As<ITransportationTeamDal>().SingleInstance();

            builder.RegisterType<TransportRequestManager>().As<ITransportRequestService>().SingleInstance();
            builder.RegisterType<EfTransportRequestDal>().As<ITransportRequestDal>().SingleInstance();

            builder.RegisterType<VehicleManager>().As<IVehicleService>().SingleInstance();
            builder.RegisterType<EfVehicleDal>().As<IVehicleDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();




        }
    }
}
