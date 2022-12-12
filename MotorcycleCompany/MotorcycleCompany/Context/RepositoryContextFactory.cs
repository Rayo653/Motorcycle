using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

using Repository;
using System;

namespace MotorcycleCompany.Context
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {           
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

             var builder = new DbContextOptionsBuilder<RepositoryContext>()
                  .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                          b => b.MigrationsAssembly("MotorcycleCompany"));
            /*var builder = new DbContextOptionsBuilder<RepositoryContext>()
                  .UseMySql(configuration.GetConnectionString("sqlConnection"),
              new MySqlServerVersion(new Version(8, 0, 30)),
                  b => b.MigrationsAssembly("MotorcycleCompany"));*/

            return new RepositoryContext(builder.Options);
        }
    }
}
