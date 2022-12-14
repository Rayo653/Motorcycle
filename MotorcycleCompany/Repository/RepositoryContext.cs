using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgencyConfiguration());

            modelBuilder.Entity<Garage>()
          .HasKey("GarageId");

            modelBuilder.Entity<Motorcycle>()
          .HasKey("MotorcycleId");

            modelBuilder.Entity<Rent>()
          .HasKey("RentId");

            modelBuilder.Entity<Phone>()
          .HasKey("PhoneId");

            modelBuilder.Entity<Client>()
          .HasKey("ClientId");

            modelBuilder.Entity<Agency>()
          .HasKey("AgencyId");

            modelBuilder.Entity<City>()
          .HasKey("CityId");
        }

        public DbSet<Garage> Garage { get; set; }
        public DbSet<Motorcycle> Motorcycle { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Rent> Rent { get; set; }
        public DbSet<Agency> Agency { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Phone> Phone { get; set; }

    }
}

