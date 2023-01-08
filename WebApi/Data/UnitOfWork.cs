using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interfaces;
using WebApi.Data.Repositories;

namespace WebApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext Dc;
        public UnitOfWork(DataContext dc)
        {
            this.Dc = dc;
        }
        public ICustomerRepository CustomerRepository => new CustomerRepository(Dc);
        public IFactoryRepository FactoryRepository => new FactoryRepository(Dc);
        public IGroupRepository GroupRepository => new GroupRepository(Dc);

        public async Task<bool> SaveAsync()
        {
            return await Dc.SaveChangesAsync() > 0;
        }
    }
}