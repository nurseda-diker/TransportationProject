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

        public DbSet<Company> Companies;
        public DbSet<Driver>  Drivers;
        public DbSet<Message> Messages;
        public DbSet<Reservation> Reservations;
        public DbSet<Review> Reviews;
        public DbSet<TransportationTeam> TransportationTeams;
        public DbSet<TransportRequest> TransportRequests;
        public DbSet<User> Users;
        public DbSet<Vehicle> Vehicles;

    }
}
