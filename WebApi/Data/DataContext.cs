using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FactoriesToCustomer>().HasKey(fc => new { fc.CustomerId, fc.FactoryCode });

            modelBuilder.Entity<FactoriesToCustomer>()
                .HasOne<Customer>(c => c.Customer)
                .WithMany(fc => fc.FactoriesToCustomer)
                .HasForeignKey(ci => ci.CustomerId);


            modelBuilder.Entity<FactoriesToCustomer>()
                .HasOne<Factory>(f => f.Factory)
                .WithMany(fc => fc.FactoriesToCustomer)
                .HasForeignKey(fi => fi.FactoryCode);


            modelBuilder.Entity<FactoriesToCustomer>()
                .HasOne<Customer>(c => c.Customer)
                .WithMany(fc => fc.FactoriesToCustomer)
                .HasForeignKey(ci => ci.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Factory> Factories => Set<Factory>();
        public DbSet<Group> Groups => Set<Group>();
        public DbSet<FactoriesToCustomer> FactoriesToCustomer => Set<FactoriesToCustomer>();
    }
}