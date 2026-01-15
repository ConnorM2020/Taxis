using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxisImporter;
using TaxisImporter.Models;

namespace TaxisImporter
{
    public class TaxiDbContext : DbContext
    {
        public TaxiDbContext() { }  // Parameterles ctor
        public TaxiDbContext(DbContextOptions options) : base(options) { }                          //This constructor allows Entity Framework Core to pass configuration settings into your TaxiDbContext, such as:
                                                                                                    //The database provider(SQL Server, PostgreSQL, etc.)
                                                                                                    //Any EF Core options(lazy loading, logging, migrations assembly, etc.)
                                                                                                    //It then forwards those options to the base DbContext class via DbContext
                                                                                                    // Standard constructor required for EF Core with <TaxiDbContext> Object aswell
        public TaxiDbContext(DbContextOptions<TaxiDbContext> options) : base(options) { } // ctor gets called by ContextFactory class                                                                                   //The connection string
        public DbSet<Taxis> Taxis { get; set; }   // Taxi Table                                                                       
                                                 
        public class TaxiDbContextFactory : IDesignTimeDbContextFactory<TaxiDbContext>
        {
            public TaxiDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<TaxiDbContext>();
                var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=TaxiDb;Trusted_Connection=True;";    // FIX
                optionsBuilder.UseSqlServer(connectionString);

                return new TaxiDbContext(optionsBuilder.Options);
            }
        }

        // OnConfiguring - prevent Warning - Updated Migrations and now working
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        //}
        // Unable to create DbContext 

    }
}
