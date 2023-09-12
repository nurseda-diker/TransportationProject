using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context:Db tabloları ile proje sınıflarını bağlama
    public class TransportationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLOCALDB;Database=Transportation;Trusted_Connection=true");
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Driver>  Drivers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<TransportationTeam> TransportationTeams { get; set; }
        public DbSet<TransportRequest> TransportRequests { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }


    }
}
