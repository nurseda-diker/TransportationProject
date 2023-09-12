using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddCors();



builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IUserDal, EfUserDal>();

builder.Services.AddSingleton<ICompanyService, CompanyManager>();
builder.Services.AddSingleton<ICompanyDal, EfCompanyDal>();

builder.Services.AddSingleton<IDriverService, DriverManager>();
builder.Services.AddSingleton<IDriverDal, EfDriverDal>();

builder.Services.AddSingleton<IMessageService, MessageManager>();
builder.Services.AddSingleton<IMessageDal, EfMessageDal>();

builder.Services.AddSingleton<IRequestTypeService, RequestTypeManager>();
builder.Services.AddSingleton<IRequestTypeDal, EfRequestTypeDal>();

builder.Services.AddSingleton<IReservationService, ReservationManager>();
builder.Services.AddSingleton<IReservationDal, EfReservationDal>();

builder.Services.AddSingleton<IReviewService, ReviewManager>();
builder.Services.AddSingleton<IReviewDal, EfReviewDal>();

builder.Services.AddSingleton<ITransportationTeamService, TransportationTeamManager>();
builder.Services.AddSingleton<ITransportationTeamDal, EfTransportationTeamDal>();

builder.Services.AddSingleton<ITransportRequestService, TransportRequestManager>();
builder.Services.AddSingleton<ITransportRequestDal, EfTransportRequestDal>();

builder.Services.AddSingleton<IVehicleService, VehicleManager>();
builder.Services.AddSingleton<IVehicleDal, EfVehicleDal>();






builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.


var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllers();

app.Run();
