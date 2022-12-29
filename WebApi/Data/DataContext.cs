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


        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Factory> Factories => Set<Factory>();
        public DbSet<Group> Groups => Set<Group>();
        public DbSet<FactoriesToCustomer> FactoriesToCustomer => Set<FactoriesToCustomer>();
    }
}