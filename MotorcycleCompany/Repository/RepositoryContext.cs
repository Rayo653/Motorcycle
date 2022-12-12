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

            modelBuilder.Entity<Agency>()
              .HasKey("AgencyId");

            modelBuilder.Entity<City>()
              .HasKey("CityId");

            modelBuilder.Entity<Client>()
              .HasKey("ClientId");

            modelBuilder.Entity<Motorcycle>()
              .HasKey("MotorcycleId");

            modelBuilder.Entity<Phone>()
              .HasKey("PhoneId");

            modelBuilder.Entity<Rent>()
              .HasKey("RentId");
        }

        public DbSet<Garage> garages { get; set; }
        public DbSet<Agency> agencies { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Motorcycle> motorcycles { get; set; }
        public DbSet<Phone> phones { get; set; }
        public DbSet<Rent> rents { get; set; }

        public DbSet<Client> Clients { get; set; }

    }
}

